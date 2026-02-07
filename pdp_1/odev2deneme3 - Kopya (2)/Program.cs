/****************************************************************************
**					SAKARYA ÜNÝVERSÝTESÝ
**			         BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
**				    BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
**				         NESNEYE DAYALI PROGRAMLAMA DERSÝ
**	
**				ÖDEV NUMARASI…...: 2
**				ÖÐRENCÝ ADI...............: Yunus Emre YILDIZ
**				ÖÐRENCÝ NUMARASI.: B231210378
**				DERS GRUBU…………: 1. ÖÐRETÝM A GRUBU
****************************************************************************/

namespace odev2deneme3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}