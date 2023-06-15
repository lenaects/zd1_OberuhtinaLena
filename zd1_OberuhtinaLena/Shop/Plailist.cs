using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    class Playlist
    {
        private List<Song> list;
        private int currentIndex;

        public Playlist()
        {
            list = new List<Song>();
            currentIndex = 0;
        }

        public Song CurrentSong()
        {
            if (list.Count > 0)
                return list[currentIndex];
            else
                throw new IndexOutOfRangeException(
                    "Невозможно получить текущую аудиозапись для пустого плейлиста!");
        }
        public void Dobav(string author, string title, string filename)
        {
            Song song = new Song
            {
                Author = author,
                Title = title,
                Filename = filename
            };
            list.Add(song);
        }
        public void Vpered()
        {
            currentIndex++;
            if (currentIndex >= list.Count)
                currentIndex = 0;
        }

        public void Nazad()
        {
            currentIndex--;
            if (currentIndex < 0)
                currentIndex = list.Count - 1;
        }
      

        public void Nachalo() { currentIndex = 0; }    
        public void Clear()
        {
            list.Clear();
            currentIndex = 0;
        }
     
        public void Delet(int index)
        {
            if (index >= 0 && index < list.Count) list.RemoveAt(index);
            else MessageBox.Show("Неправильный индекс");
        }

        public void Delet(Song song)
        {
            int index = list.FindIndex(s => s.Equals(song));
            if (index != -1) list.RemoveAt(index);
        }
    }
}
