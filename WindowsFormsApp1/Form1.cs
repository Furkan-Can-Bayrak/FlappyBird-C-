using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 15;   //Boruların hızı
        int gravity = 10;       //yer çekimi
        int score = 0;          //skor
        Random rand = new Random(); //boruların konumları dinamik olması için random sınıfı
        bool isJumping = false;     //zıplıyor mu değişkeni kuşun zıpladığını anlamak için
        int record = 0;             //Rekor skoru tutar


        public Form1()
        {
            InitializeComponent();  //Formu başlatır
        }

        private void Score_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void timerEvent(object sender, EventArgs e)
        {

            if (isJumping)
            {
                // Zıplama hareketi için
                bird.Top -= gravity; // Kuş yukarı hareket eder
                isJumping = false; // Zıplama tamamlandı
            }
            else
            {
                // Yer çekimini uygula
                bird.Top += gravity;
            }


            pipe.Left -= pipeSpeed;         //Alt boruyu hızı kadar sola hareket ettirir
            pipeDown.Left -= pipeSpeed;     //Üst boruyu hızı kadar sola hareket ettirir
            scoreInput.Text = "Score: " + score;        //Kişinin skorunu yazar

            if (pipeDown.Left < -150)       //Eğer üst boru x koordinatında -150ye gelmişse
            {
                pipeDown.Left = 800;                // x=800 koordinatına götür
                pipeDown.Top = rand.Next(-200, 0);  // y koordinatında -200 0 arasında random değer üret. Üretilen değer y koordinatı olacak
            }

            if (pipe.Left < -150)           //Eğer alt boru x koordinatında -150ye gelmişse
            {
                pipe.Left = 800;            // x=800 koordinatına götür
                pipe.Top = pipeDown.Top + pipeDown.Height + rand.Next(145, 165);    // üst boruya göre arasında 145 165 arası mesafe olacak şekilde ayarlandı
                score++;                //skoru 1 arttır
            }

            if (bird.Bounds.IntersectsWith(pipe.Bounds) ||          //Eğer boruya veya zemine değerse true döner
                bird.Bounds.IntersectsWith(pipeDown.Bounds) ||
                bird.Bounds.IntersectsWith(ground.Bounds)
                )
            {                   
                if (score > record)         //skor rekordan büyükse artık yeni skor yeni rekordur
                {
                    record = score;
                }
                endGame();      //oyunu bitiren fonksiyon
            }

            if (bird.Top < 0)
            {
                bird.Top = 0;       //gözükmeyen yerlere uçmasın diye tavandan yukarı çıkması engelleniyor
            }
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            // Oyun devam ediyorsa zıplamaya izin ver
            if (e.KeyCode == Keys.Space && !isJumping && timer.Enabled)
            {
                isJumping = true; // Zıplama başladı
                bird.Top -= 50; // Kuş yukarı hareket eder
            }

            // Oyun bittiğinde 'R' tuşuna basıldığında oyunu yeniden başlat
            if (e.KeyCode == Keys.R && !timer.Enabled)
            {
                RestartGame(); // Oyunu yeniden başlat
            }
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                isJumping = false; // Tuş bırakılınca zıplama durumu sıfırlanır 
            }

        }

        private void Form1_Load(object sender, EventArgs e) //Oyun başladığında çalışan fonksiyon
        {
            timer.Interval = 30; // Timer interval ayarlanıyor (30 ms)
            timer.Start();
        }

        private void endGame()
        {
            timer.Stop();
            scoreInput.Text = "Oyun Bitti!! Skorun: " + score + "\nTekrar oynamak için 'R' tuşuna basın.";
        }
        private void RestartGame()
        {
            // Başlangıç değerlerini sıfırlıyoruz
            score = 0;
            bird.Top = 100; // Kuşun başlangıç yüksekliği

            // Boruları yeni oyun için konumlandırdık
            pipe.Left = 800; // Boru başlangıç konumu
            pipeDown.Left = 800; // Üst boru başlangıç konumu

            timer.Start(); // Timer'ı başlat
            scoreInput.Text = "Score: " + score; // Skoru sıfır yaptık
            recordInput.Text = "Rekor: " + record; //Rekor da son rekor ne ise o olarak yazıldı
        }

        private void record_Click(object sender, EventArgs e)
        {

        }
    }
}
