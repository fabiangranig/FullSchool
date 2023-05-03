using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20230320_Memory
{
    class C_Ranking
    {
        private List<C_NameWithScore> _NamesWithScores;

        //Constructor
        public C_Ranking()
        {
            _NamesWithScores = new List<C_NameWithScore>();

            //Get the current scores from the .txt
            GetScoresFromTxt();
        }

        //encapsulation
        public List<C_NameWithScore> NamesWithScores
        {
            get { return _NamesWithScores; }
        }

        public void GetScoresFromTxt()
        {
            string[] all_lines = File.ReadAllLines(@"rankings.txt");
            _NamesWithScores = new List<C_NameWithScore>();

            //Parse them to to the right format
            for(int i = 0; i < all_lines.Length; i++)
            {
                string[] split = all_lines[i].Split(';');
                _NamesWithScores.Add(new C_NameWithScore(split[0], Int32.Parse(split[1])));
            }
        }

        public void AddValuesToTxt(string name, int score)
        {
            int list_size = File.ReadAllLines(@"rankings.txt").Length;

            FileStream fs = new FileStream(@"rankings.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(name + ";" + score);

            sw.Close();
            fs.Close();
        }

        public List<C_NameWithScore> SortedList()
        {
            List<C_NameWithScore> temp = NamesWithScores;

            //Bubble Sort the list
            for (int i = 0; i < temp.Count; i++)
            {
                for(int u = 0; u < temp.Count; u++)
                {
                    if(temp[i]._Score > temp[u]._Score)
                    {
                        C_NameWithScore temp2 = temp[i];
                        temp[i] = temp[u];
                        temp[u] = temp2;
                    }
                }
            }

            //Return the sorted list
            return temp;
        }
    }
}
