using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;
using System.IO;

namespace DataAccessLayer
{
    public class DataAccessor
    {
        public static List<Monster> RetrieveMonsterList()
        {
            List<Monster> monsterList = new List<Monster>();

            char[] separator = { ',' };

            try
            {
                StreamReader fileReader = new StreamReader(AppData.DataPath + "\\" + AppData.MonsterListFileName);

                while (fileReader.EndOfStream == false)
                {
                    string line = fileReader.ReadLine();
                    string[] parts;

                    if (line.Length > 16)
                    {
                        parts = line.Split(separator);
                        if (parts.Count() == 5)
                        {
                            Monster newMonster = new Monster();
                            newMonster.Name = parts[0];
                            newMonster.Type = parts[1];
                            newMonster.Size = parts[2];
                            newMonster.ArticleFileName = parts[3];
                            newMonster.ImageFileName = parts[4];

                            monsterList.Add(newMonster);
                        }
                    }
                }
                fileReader.Close();
            }
            catch (Exception up)
            {
                throw up;
            }
            return monsterList;
        }

        public static MonsterArticle RetrieveMonsterArticle(Monster monster)
        {
            MonsterArticle monsterArticle = new MonsterArticle();

            StreamReader fileReader = null;

            try
            {
                fileReader = new StreamReader(AppData.DataPath + "\\" + monster.ArticleFileName);
                monsterArticle.title = fileReader.ReadLine();
                monsterArticle.ArticleText = fileReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                fileReader.Close();
            }

            return monsterArticle;
        }
    }
}
