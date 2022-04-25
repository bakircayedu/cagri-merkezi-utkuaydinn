namespace odev200601019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }






        Cagri cagri = new Cagri();

                    Temsilci temsilci1= new Temsilci();


           Temsilci temsilci2= new Temsilci();


                    Temsilci temsilci3= new Temsilci();


           Temsilci temsilci4= new Temsilci();


        LinkedList<Cagri> cagriListesi= new LinkedList<Cagri>();


              LinkedList<Musteri> bekleyenlerListesi = new LinkedList<Musteri>();





        
        private void Form1_Load(object sender, EventArgs e)
        {


            temsilci1.Ad = "Utku";

            temsilci1.SoyAd="Aydýn";

            temsilci1.musteriTur= MusteriTur.Ticari;

            temsilci1.temsilciOzelNo = 1;





            temsilci2.Ad="Rahþan";

            temsilci2.SoyAd="Aydýn";

            temsilci2.musteriTur=MusteriTur.Ticari;

            temsilci2.temsilciOzelNo=2;

            




            temsilci3.Ad="Enes";

            temsilci3.SoyAd="Ayaydýn";

            temsilci3.musteriTur=MusteriTur.Bireysel;

            temsilci3.temsilciOzelNo= 3;

            




            temsilci4.Ad="Nilüfer";

            temsilci4.SoyAd="Beyaz";

            temsilci4.musteriTur=MusteriTur.Bireysel;

            temsilci4.temsilciOzelNo=4;

            


            

        }
        
        private void btnYönlendir_Click(object sender, EventArgs e)
        {
            foreach (var item in bekleyenlerListesi.DisplayElements())
            {


                if (  temsilci1.Drm == ENDurum.Bos && item.musteriTur == MusteriTur.Bireysel  )
                {
                    bekleyenlerListesi.Delete(item);

                    temsilci1.Drm = ENDurum.Dolu;
                    
                    cagri.temsilci = temsilci1;

                    cagri.musteri = item;

                    temsilci1.musteri = item;

                    



                    Yenile();


                    Goruntule();


                }


                else if (  temsilci2.Drm == ENDurum.Bos && item.musteriTur == MusteriTur.Bireysel  )
                {
                    bekleyenlerListesi.Delete(item);

                    temsilci2.Drm = ENDurum.Dolu;
                    
                    cagri.temsilci = temsilci2;

                    cagri.musteri = item;

                    temsilci2.musteri = item;

                    


                    Yenile();


                    Goruntule();


                }
                if (  temsilci3.Drm == ENDurum.Bos && item.musteriTur == MusteriTur.Ticari  )
                {
                    bekleyenlerListesi.Delete(item);

                    temsilci3.Drm = ENDurum.Dolu;
                    
                    cagri.temsilci = temsilci3;

                    cagri.musteri = item;

                    temsilci3.musteri = item;

                    



                    Yenile();


                    Goruntule();


                }
                else if (  temsilci4.Drm == ENDurum.Bos && item.musteriTur == MusteriTur.Ticari  )
                {
                      bekleyenlerListesi.Delete(item);

                    temsilci4.Drm = ENDurum.Dolu;
                    
                    cagri.temsilci = temsilci4;

                    cagri.musteri = item;

                    temsilci4.musteri = item;

                    


                    Yenile();


                    Goruntule();


                }
            }
        }

        

        




        private void btnBitir1_Click(object sender, EventArgs e)
        {


            if (temsilci1.Drm == ENDurum.Dolu)
            {

                foreach (var item in cagriListesi.DisplayElements())
                {

                    if (item.musteri == temsilci1.musteri)
                    {

                           temsilci1.musteri = null;

                        cagriListesi.Insert(item);

                        item.Not = richTextBox1.Text;

                        item.bitisZamani = DateTime.Now;

                        Detaylar.Items.Add(item.Not);




                    }

                }


                temsilci1.Drm = ENDurum.Bos;

            }


            Yenile();

        }







        private void btnBitir2_Click(object sender, EventArgs e)
        {

            if (temsilci2.Drm == ENDurum.Dolu)
            {

                foreach (var item in cagriListesi.DisplayElements())
                {

                    if (item.musteri == temsilci2.musteri)
                    {

                           temsilci2.musteri = null;   
                        
                        cagriListesi.Insert(item);

                        item.Not = richTextBox2.Text;
                        
                        item.bitisZamani = DateTime.Now;

                        Detaylar.Items.Add(item.Not);

                        

                    }

                }


                temsilci2.Drm = ENDurum.Bos;

            }


            Yenile();

        }



        private void btnBitir3_Click(object sender, EventArgs e)
        {
            if (temsilci3.Drm == ENDurum.Dolu)
            {

                foreach (var item in cagriListesi.DisplayElements())
                {

                    if (item.musteri == temsilci3.musteri)
                    {

                           temsilci3.musteri = null;

                        cagriListesi.Insert(item);

                        item.Not = richTextBox3.Text;

                        item.bitisZamani = DateTime.Now;

                        Detaylar.Items.Add(item.Not);


                    }

                }


                temsilci3.Drm = ENDurum.Bos;

            }


            Yenile();

        }




        private void btnBitir4_Click(object sender, EventArgs e)
        {
            if (temsilci4.Drm == ENDurum.Dolu)
            {

                foreach (  var item in cagriListesi.DisplayElements()   )
                {


                    if (item.musteri == temsilci4.musteri)
                    {

                           temsilci4.musteri = null;
                        
                        cagriListesi.Insert(item);

                        item.Not = richTextBox4.Text;
                        
                        item.bitisZamani = DateTime.Now;

                        Detaylar.Items.Add(item.Not);



                    }


                }


                temsilci4.Drm = ENDurum.Bos;
            }


            Yenile();

        }

        private void btnAra_Click(object sender, EventArgs e)
        {

            Cagri cagri = new Cagri();
            
            Musteri musteri = new Musteri();
            
            musteri.Ad = txtIsim.Text;
            
            musteri.SoyAd = txtSoyIsim.Text;
            
            musteri.MusteriNo = bekleyenlerListesi.Size + 1;
            
            musteri.Telefon = txtTelefon.Text;
            

            if (radioBtnBireysel.Checked == true)
            {

                musteri.musteriTur = MusteriTur.Bireysel;

            }

            else
            {

                musteri.musteriTur = MusteriTur.Ticari;

            }


            cagriListesi.Insert(cagri);

            bekleyenlerListesi.Insert(musteri);

            cagri.musteri = musteri;

            cagri.baslangicZamani = DateTime.Now;

          

            Goruntule();

        }












        public void Goruntule()
        {
            Bekleyenler.Items.Clear();

            foreach (var item in bekleyenlerListesi.DisplayElements())
            {

                Bekleyenler.Items.Add("Musteri Adi: " + item.Ad);
                
                Bekleyenler.Items.Add("Musteri Soyadi: " + item.SoyAd);
                
                Bekleyenler.Items.Add("Musteri Numarasi: " + item.MusteriNo);
                
                Bekleyenler.Items.Add("Musteri Tel No: " + item.Telefon);
                
                Bekleyenler.Items.Add("/-/-/-/-/-/-/-/-/-/-/");
            
            }

        }



        public void Yenile()
        {


            Temsilci1.Items.Clear();

            Temsilci2.Items.Clear();

            Temsilci3.Items.Clear();

            Temsilci4.Items.Clear();







            Temsilci1.Items.Add("Temsilcinin Ýsmi--> " + temsilci1.Ad);

            Temsilci1.Items.Add("Temsilcinin Soyismi--> " + temsilci1.SoyAd);

            Temsilci1.Items.Add("Temsilcinin Durumu--> " + temsilci1.Drm);

            Temsilci1.Items.Add("Temsilcinin Türü--> " + temsilci1.musteriTur);
            
            
            


            Temsilci2.Items.Add("Temsilcinin Ýsmi--> " + temsilci2.Ad);
            
            Temsilci2.Items.Add("Temsilcinin Soyismi--> " + temsilci2.SoyAd);

            Temsilci2.Items.Add("Temsilcinin Durumu--> "+temsilci2.Drm);

            Temsilci2.Items.Add("Temsilcinin Türü--> " + temsilci2.musteriTur);
            
            



            
            Temsilci3.Items.Add("Temsilcinin Ýsmi--> "+temsilci3.Ad);
            
            Temsilci3.Items.Add("Temsilcinin Soyismi--> "+temsilci3.SoyAd);

            Temsilci3.Items.Add("Temsilcinin Durumu--> "+temsilci3.Drm);

            Temsilci3.Items.Add("Temsilcinin Türü--> "+temsilci3.musteriTur);
            
            
            
            
            Temsilci4.Items.Add("Temsilcinin Ýsmi--> " + temsilci4.Ad);
            
            Temsilci4.Items.Add("Temsilcinin Soyismi--> " + temsilci4.SoyAd);
            
            Temsilci4.Items.Add("Temsilcinin Durumu--> " + temsilci4.Drm);

            Temsilci4.Items.Add("Temsilcinin Türü--> " + temsilci4.musteriTur);

        }
    }
}