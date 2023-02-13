using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;
using DataAccessLayer;

namespace LogicLayer
{
    public class ArticleLogic
    {
        public List<Monster> FetchMonsterList()
        {
            List<Monster> monsterList = null;

            try
            {
                monsterList = DataAccessor.RetrieveMonsterList();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Your data was not availible", ex);
            }

            return monsterList;
        }

        public MonsterArticle FetchMonsterArticle(Monster monster)
        {
            MonsterArticle monsterArticle = null;

            try
            {
                monsterArticle = DataAccessor.RetrieveMonsterArticle(monster);
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Your article was not availible", ex);
            }

            return monsterArticle;
        }
    }
}
