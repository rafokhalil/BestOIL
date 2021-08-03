using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil
{
    public partial class BestOilCompany : Form
    {
        public double TotalPriceOil { get; set; }
        public double TotalPriceCafe { get; set; }
        public double TotalPrice { get; set; }

        public BestOilCompany()
        {
            InitializeComponent();
        }

        private void BestOilCompany_Load(object sender, EventArgs e)
        {
            benzinCombobx.DisplayMember = "Name";
            List<Oils> oils = new List<Oils>
            {
                new Oils{
                Name="AI-98",
                Price=1.50
                },
                new Oils{
                Name="AI-95",
                Price=1.25
                },
                new Oils{
                Name="AI-92",
                Price=0.90
                },
                new Oils{
                Name="Dizel",
                Price=0.60
                }
            };
            benzinCombobx.DataSource = oils;
            Cafe hotdog = new Cafe() { 
             Name="Hot-Dog",
             Price=2
            };
            Cafe hamburger = new Cafe()
            {
                Name = "Hamburger",
                Price = 3
            };
            Cafe cola = new Cafe()
            {
                Name = "Coca-cola",
                Price = 1
            };
            Cafe fri = new Cafe()
            {
                Name = "Kartof-Free",
                Price = 2
            };
            hotdogAmountTxtbx.Text = hotdog.Price.ToString();
            hamburgerTxtbx.Text = hamburger.Price.ToString();
            colaTxtbx.Text = cola.Price.ToString();
            kartoffriTxtbx.Text = fri.Price.ToString();
        }

        private void benzinCombobx_SelectedIndexChanged(object sender, EventArgs e)
        {
            var oil = benzinCombobx.SelectedItem as Oils;
            valueOilTxtbx.Text = oil.Price.ToString();
        }

        private void click(object sender, EventArgs e)
        {
            tutar.Enabled = true;
            value.Enabled = false;
        }

        new private void Click(object sender, EventArgs e)
        {
            tutar.Enabled = false;
            value.Enabled = true;
        }

        private void tutar_TextChanged(object sender, EventArgs e)
        {
            var oil = benzinCombobx.SelectedItem as Oils;
            var tutarText = double.Parse(tutar.Text) * oil.Price;
            saygacOilLbl.Text = tutarText.ToString();
            TotalPriceOil = tutarText;
            totalAmountLbl.Text = (TotalPriceOil + TotalPriceCafe).ToString();
        }

        private void value_TextChanged(object sender, EventArgs e)
        {
            var oil = benzinCombobx.SelectedItem as Oils;
            var valueText = double.Parse(value.Text) / oil.Price;
            saygacOilLbl.Text = value.Text;
            TotalPriceOil = double.Parse(value.Text);
            totalAmountLbl.Text = (TotalPriceOil + TotalPriceCafe).ToString();
        }

        private void hotDogChkbx_CheckedChanged(object sender, EventArgs e)
        {
            hotdogValueTxtbx.Enabled = true;
        }

        private void hamburgerChekbx_CheckedChanged(object sender, EventArgs e)
        {
            hamburgerValueTxtbx.Enabled = true;
        }

        private void friChkbx_CheckedChanged(object sender, EventArgs e)
        {
            friValueTxtbx.Enabled = true;
        }

        private void colaChkbx_CheckedChanged(object sender, EventArgs e)
        {
            colaValueTxtbx.Enabled = true;
        }

        private void hotdogValueTxtbx_TextChanged(object sender, EventArgs e)
        {
            var result = double.Parse(hotdogAmountTxtbx.Text) * double.Parse(hotdogValueTxtbx.Text);
            TotalPriceCafe += result;
            cafeValueLbl.Text = TotalPriceCafe.ToString();
            TotalPrice += TotalPriceCafe;
            totalAmountLbl.Text = (TotalPriceOil + TotalPriceCafe).ToString();
        }

        private void hamburgerValueTxtbx_TextChanged(object sender, EventArgs e)
        {
            var result = double.Parse(hamburgerTxtbx.Text) * double.Parse(hamburgerValueTxtbx.Text);
            TotalPriceCafe += result;
            cafeValueLbl.Text = TotalPriceCafe.ToString();
            TotalPrice += TotalPriceCafe;
            totalAmountLbl.Text = (TotalPriceOil + TotalPriceCafe).ToString();
        }

        private void friValueTxtbx_TextChanged(object sender, EventArgs e)
        {
            var result = double.Parse(kartoffriTxtbx.Text) * double.Parse(friValueTxtbx.Text);
            TotalPriceCafe += result;
            cafeValueLbl.Text = TotalPriceCafe.ToString();
            TotalPrice += TotalPriceCafe;
            totalAmountLbl.Text = (TotalPriceOil + TotalPriceCafe).ToString();
        }

        private void colaValueTxtbx_TextChanged(object sender, EventArgs e)
        {
            var result = double.Parse(colaTxtbx.Text) * double.Parse(colaValueTxtbx.Text);
            TotalPriceCafe += result;
            cafeValueLbl.Text = TotalPriceCafe.ToString();
            TotalPrice += TotalPriceCafe;
            totalAmountLbl.Text = (TotalPriceOil + TotalPriceCafe).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Created with PDFsharp";

            PdfPage page = document.AddPage();

            XGraphics gfx = XGraphics.FromPdfPage(page);

            XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);

            gfx.DrawString($@"=======Best Oil======== ", font, XBrushes.Black,
            new XRect(0, 0, page.Width, page.Height),
            XStringFormats.TopCenter);
            gfx.DrawString($@"Total Cafe Amount : {saygacOilLbl.Text} Azn", font, XBrushes.Black,
            new XRect(10, 20, page.Width, page.Height),
            XStringFormats.TopLeft);
            gfx.DrawString($@"Total Oil Amount : {cafeValueLbl.Text} Azn", font, XBrushes.Black,
            new XRect(10, 40, page.Width, page.Height),
            XStringFormats.TopLeft);
            gfx.DrawString($@"Total Price : {totalAmountLbl.Text} Azn", font, XBrushes.Black,
            new XRect(10, 60, page.Width, page.Height),
            XStringFormats.TopLeft);
            const string filename = "Amount.pdf";
            document.Save(filename);
            Process.Start(filename);
        }
    }
}
