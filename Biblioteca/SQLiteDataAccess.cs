using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class SQLiteDataAccess
    {
        #region CREATE
        public static void InsertAluno(Aluno aluno)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO Aluno (Name, Surname) VALUES (@Name, @Surname)", aluno);
            }
        }

        public static void InsertDisciplina(Disciplina disciplina)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO Disciplina (Name, Description) VALUES (@Name, @Description)", disciplina);
            }
        }

        public static void InsertAlunoDisciplina(AlunoDisciplina alunoDisciplina)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"INSERT INTO AlunoDisciplina (IdAluno, IdDisciplina) VALUES ({alunoDisciplina.IdAluno}, {alunoDisciplina.IdDisciplina})");
            }
        }
        #endregion

        #region READ
        public static List<Aluno> LoadAlunos()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Aluno>("SELECT * FROM Aluno");

                return output.ToList();
            }
        }

        public static List<Disciplina> LoadDisciplinas()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Disciplina>("SELECT * FROM Disciplina");

                return output.ToList();
            }
        }

        public static List<AlunoDisciplina> LoadAlunoDisciplina()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<AlunoDisciplina>("SELECT * FROM AlunoDisciplina");

                return output.ToList();
            }
        }
        #endregion

        #region DELETE
        public static void DeleteAluno(Aluno aluno)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"DELETE FROM Aluno WHERE IdAluno = {aluno.IdAluno}");
            }
        }

        public static void DeleteDisciplina(Disciplina disciplina)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"DELETE FROM Disciplina WHERE IdDisciplina = {disciplina.IdDisciplina}");
            }
        }

        public static void DeleteAlunoDisciplina(Aluno aluno, Disciplina disciplina)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"DELETE FROM AlunoDisciplina WHERE IdAluno = {aluno.IdAluno} AND IdDisciplina = {disciplina.IdDisciplina}");
            }
        }
        #endregion

        public static async Task<List<Aluno>> LoadAlunosAsync()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var sql = "SELECT a.IdAluno, a.Name, a.Surname, d.IdDisciplina, d.Name, d.Description " +
                    "FROM Aluno a " +
                    "INNER JOIN AlunoDisciplina ad on ad.IdAluno = a.IdAluno " +
                    "INNER JOIN Disciplina d on d.IdDisciplina = ad.IdDisciplina";

                var alunos = await cnn.QueryAsync<Aluno, Disciplina, Aluno>(sql, (aluno, discipplina) =>
                {
                    aluno.Disciplinas.Add(discipplina);
                    return aluno;
                }, splitOn: "IdDisciplina");

                var result = alunos.GroupBy(a => a.IdAluno).Select(g =>
                {
                    var grupoAlunos = g.First();
                    grupoAlunos.Disciplinas = g.Select(d => d.Disciplinas.Single()).ToList();
                    return grupoAlunos;
                });


                return result.ToList();
            }
        }

        public static async Task<List<Disciplina>> LoadDisciplinasAsync()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                /// /// /// CHANGE QUERY /// /// ///
                var sql = "SELECT d.IdDisciplina, d.Name, d.Description, a.IdAluno, a.Name, a.Surname " +
                    "FROM Disciplina d " +
                    "INNER JOIN AlunoDisciplina ad on ad.IdDisciplina = d.IdDisciplina " +
                    "INNER JOIN Aluno a on a.IdAluno = ad.IdAluno";
                /// /// /// CHANGE QUERY /// /// ///

                var disciplinas = await cnn.QueryAsync<Disciplina, Aluno, Disciplina>(sql, (disciplina, aluno) =>
                {
                    disciplina.Alunos.Add(aluno);
                    return disciplina;
                }, splitOn: "IdAluno");

                var result = disciplinas.GroupBy(a => a.IdDisciplina).Select(g =>
                {
                    var grupoDisciplinas = g.First();
                    grupoDisciplinas.Alunos = g.Select(d => d.Alunos.Single()).ToList();
                    return grupoDisciplinas;
                });


                return result.ToList();
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
