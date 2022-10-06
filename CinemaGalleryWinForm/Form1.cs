using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaGalleryWinForm
{
    public partial class Form1 : Form
    {
        DatabaseCinemaGalleryEntities1 db;
        List<Peliculas> Peliculas;
        List<Directores> Directores;
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            using (DatabaseCinemaGalleryEntities1 db = new DatabaseCinemaGalleryEntities1())
            {
                Peliculas = db.Peliculas.ToList();
                Directores = db.Directores.ToList();
                GetDirectoresCombobox();
            }
            GetListBox();
        }
        private void GetDirectoresCombobox()
        {
            if (Directores.Count > 0)
            {
                foreach (Directores directores in Directores)
                {
                    cbDirectores.Items.Add(directores);
                }
            }
        }
        private void GetListBox()
        {     
            listBoxPeliculas.Items.Add(Peliculas[Peliculas.Count - 1].titulo_original);
            
            
            
        }

        private void toolStripButtonMas_Click(object sender, EventArgs e)
        {
            using (DatabaseCinemaGalleryEntities1 db = new DatabaseCinemaGalleryEntities1())
            {

                listBoxPeliculas.Items.Add(textBoxOriginalTitle.Text);
                int NumeroPeliculas = Peliculas.Count();
                Peliculas pelicula = new Peliculas();
                pelicula.Id = NumeroPeliculas + 1;
                pelicula.titulo_original = textBoxOriginalTitle.Text;
                pelicula.titulo_traducido = textBoxTranslateTitle.Text;
                pelicula.director = cbDirectores.Text;
                pelicula.duraccion = textBoxDuration.Text;
                pelicula.url = textBoxUrl.Text;
                pelicula.calificacion_IMBD = textBoxRatingImdb.Text;
                pelicula.calificacion_propia = textBoxOwnRating.Text;
                pelicula.descripcion_ = textBoxDescription.Text;
                pelicula.comentarios = textBoxComments.Text;
            
                Peliculas.Add(pelicula);
            
                db.Peliculas.Add(pelicula);
                db.SaveChanges();
            }
                
            


        }

        private async void listBoxPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            var objSelect = listBoxPeliculas.SelectedItem;
            if (objSelect != null)
            {
                string objNow = objSelect.ToString();
                //buscar en la base de datos el nombre
                using (DatabaseCinemaGalleryEntities1 db = new DatabaseCinemaGalleryEntities1())
                {
                    var pelicula = db.Peliculas.FirstOrDefault(x => x.titulo_original == objNow);
                    
                    pelicula.titulo_original = textBoxOriginalTitle.Text;
                    pelicula.titulo_traducido = textBoxTranslateTitle.Text;
                    pelicula.director = cbDirectores.Text;
                    pelicula.duraccion = textBoxDuration.Text;
                    pelicula.url = textBoxUrl.Text;
                    pelicula.calificacion_IMBD = textBoxRatingImdb.Text;
                    pelicula.calificacion_propia = textBoxOwnRating.Text;
                    pelicula.descripcion_ = textBoxDescription.Text;
                    pelicula.comentarios = textBoxComments.Text;

                }
            }
            
        }
    }
}
