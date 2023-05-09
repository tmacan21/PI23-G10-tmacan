using DBLayer;
using Evaluation_Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager.Repositories
{
    public class ActivityRepository
    {
        public static ActivityRepository GetActivity(int  id)
        {
            ActivityRepository activity = null;
            string sql = $"SELECT * FROM Activities WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                activity = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return activity;
        }

        public static List<ActivityRepository> GetActivities()
        {
            List <ActivityRepository> activities = new List<ActivityRepository>();
            string sql = "SELECT * FROM Activities";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                ActivityRepository activity = CreateObject(reader);
                activities.Add(activity);
            }

            reader.Close();
            DB.CloseConnection();

            return activities;
        }

        private static ActivityRepository CreateObject(object reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string name = reader["Name"].ToString();
            string description = reader["Description"].ToString();
            int maxPoints = int.Parse(reader["MaxPoints"].ToString());
            int minPointsForGrade = int.Parse(reader["MinPointsForGrade"].ToString());
            int minPointsForSignature = int.Parse(reader["MinPointsForSignature"].ToString());

            var activity = new Activity()
            {
                Id = id,
                Name = name,
                Description = description,
                MaxPoints = maxPoints,
                MinPointsForSignature = minPointsForSignature,
                MinPointsForGrade = minPointsForGrade,
            };

            return Activity;
        }
    }
}
