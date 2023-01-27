using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodMenu
{
    public partial class Form1 : Form
    {
        //string[] totalIngredientes = new string[21];
        //int ingrediente = totalIngredientes[21];
        //string[] baseDescripcion = new string[4];
        string[] baseDescripcion = new string[] { "Arroz", "Tallarines", "Fideos de Pepino", "Lechuga" };
        string[] toppingDescripcion= new string[] { "Mango", "Durazno", "Tomates", "Edemame", "Mushrooms" };
        string[] proteinaDescripcion= new string[] { "Pillo", "Cerdo", "Rollo Primavera", "Surimi" };
        string[] crujienteDescripcion = new string[] { "Arandanos", "Amaranto", "Cacauate", "Semilla de Girasol" };
        string[] aderezoDescripcion = new string[] { "Aderezo HKE", "Agridulce", "Soya", "Mango Habanero" };
        int baseTotal = 0;
        bool bAse = false;
        int toppingTotal = 0;
        bool topping = false;
        int proteinaTotal = 0;
        bool proteina = false;
        int crujienteTotal = 0;
        bool crujiente = false;
        int aderezoTotal = 0;
        bool aderezo = false;

        
        public Form1()
        {
            InitializeComponent();
        }

        //INGREDIENTES PARA LA BASE, SOLO 1 A ELEGIR
        private void lbaArroz_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chbxArroz.CheckState == CheckState.Checked)
            {
                baseTotal++;
                baseDescripcion[0] = Convert.ToString(chbxArroz.Checked);
                
                //baseDescripcion[] = " Arroz";
            }
            else if (chbxArroz.ThreeState == false)
            {
                baseTotal--;
            }
        }

        private void lblTallarines_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxTallarines.CheckState ==CheckState.Checked)
            {
                baseTotal ++;
                baseDescripcion[1] = Convert.ToString(chbxTallarines.Checked);
                //  baseDescripcion[1] = " Tallarines";
            }
            else if(chbxTallarines.ThreeState == false)
            {
                baseTotal --;
            }
            
        
        }
        private void chbxFideos_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxFideos.CheckState == CheckState.Checked)
            {
                baseTotal++; 
                baseDescripcion[2] = Convert.ToString(chbxFideos.Checked);
               
                //  baseDescripcion[2] = " Fideos";
            }
            else if (chbxFideos.ThreeState == false)
            {
                baseTotal--;
            }
        }

        private void chbxLechuga_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxLechuga.CheckState == CheckState.Checked)
            {
                baseTotal++;
                baseDescripcion[3] = Convert.ToString(chbxLechuga.Checked);
                //  baseDescripcion[3] = " Lechuga";
            }
            else if (chbxLechuga.ThreeState == false)
            {
                baseTotal--;
            }
        }
        //INGREDIENTES PARA LOS TOPPINGS, ELIGE HASTA 3
        private void chbxMango_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxMango.CheckState == CheckState.Checked)
            {
                toppingTotal++;
                toppingDescripcion[0] = Convert.ToString(chbxMango.Checked);               
                // toppingDescripcion[0] = " Mango";
            }
            else if (chbxMango.ThreeState == false)
            {
                toppingTotal--;
            }
        }

        private void chbxDurazno_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxDurazno.CheckState == CheckState.Checked)
            {
                toppingTotal++;
                toppingDescripcion[1] = Convert.ToString(chbxDurazno.Checked);              
                // toppingDescripcion[1] = "Durazno";
            }
            else if (chbxDurazno.ThreeState == false)
            {
                toppingTotal--;
            }
        }

        private void chbxTomate_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxTomate.CheckState == CheckState.Checked)
            {
                toppingTotal++;
                toppingDescripcion[2] = Convert.ToString(chbxTomate.Checked);               
                //  toppingDescripcion[2] = "Tomate";
            }
            else if (chbxTomate.ThreeState == false)
            {
                toppingTotal--;
            }
        }

        private void chbxEdemame_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxEdemame.CheckState == CheckState.Checked)
            {
                toppingTotal++;
                toppingDescripcion[3] = Convert.ToString(chbxEdemame.Checked);              
                //  toppingDescripcion[3] = "Edemame";
            }
            else if (chbxEdemame.ThreeState == false)
            {
                toppingTotal--;
            }
        }

        private void chbxMushroom_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxMushroom.CheckState == CheckState.Checked)
            {
                toppingTotal++;
                toppingDescripcion[4] = Convert.ToString(chbxMushroom.Checked);
                //   toppingDescripcion[4] = "Mushrooms";
            }
            else if (chbxMushroom.ThreeState == false)
            {
                toppingTotal--;
            }
        }
        //INGREDIENTES PARA PROTEINA, ELIGE HASTA 2
        private void chbxPollo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxPollo.CheckState == CheckState.Checked)
            {
                proteinaTotal++;
                proteinaDescripcion[0] = Convert.ToString(chbxPollo.Checked);               
                // proteinaDescripcion[0] = "Pollo";
            }
            else if (chbxPollo.ThreeState == false)
            {
                proteinaTotal--;
            }
        }

        private void chbxCerdo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxCerdo.CheckState == CheckState.Checked)
            {
                proteinaTotal++;
                proteinaDescripcion[1] = Convert.ToString(chbxCerdo.Checked);              
                //  proteinaDescripcion[1] = "Cerdo";
            }
            else if (chbxCerdo.ThreeState == false)
            {
                proteinaTotal--;
            }
        }

        private void chbxRolloPri_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxRolloPri.CheckState == CheckState.Checked)
            {
                proteinaTotal++;
                proteinaDescripcion[2] = Convert.ToString(chbxRolloPri.Checked);            
                // proteinaDescripcion[2] = "Rollo Primavera";
            }
            else if (chbxRolloPri.ThreeState == false)
            {
                proteinaTotal--;
            }
        }

        private void chbxSurimi_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxSurimi.CheckState == CheckState.Checked)
            {
                proteinaTotal++;
                proteinaDescripcion[3] = Convert.ToString(chbxSurimi.Checked);
                //  proteinaDescripcion[3] = "Surimi";
            }
            else if (chbxSurimi.ThreeState == false)
            {
                proteinaTotal--;
            }
        }
        //INGREDIENTES PARA CRUJIENTES, ELIGE HASTA 2
        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            //arandanos
            if (chbxArandanos.CheckState == CheckState.Checked)
            {
                crujienteTotal++;
                crujienteDescripcion[0] = Convert.ToString(chbxArandanos.Checked);               
                // crujienteDescripcion[0] = "Arandanos";
            }
            else if (chbxArandanos.ThreeState == false)
            {
                crujienteTotal--;
            }

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            //amaranto
            if (chbxAmaranto.CheckState == CheckState.Checked)
            {
                crujienteTotal++;
                crujienteDescripcion[1] = Convert.ToString(chbxAmaranto.Checked);               
                //  crujienteDescripcion[1] = "Amaranto";
            }
            else if (chbxAmaranto.ThreeState == false)
            {
                crujienteTotal--;
            }

        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            //cacahuate
            if (chbxCacahuate.CheckState == CheckState.Checked)
            {
                crujienteTotal++;
                crujienteDescripcion[2] = Convert.ToString(chbxCacahuate.Checked);               
                // crujienteDescripcion[2] = "Cacahuates";
            }
            else if (chbxCacahuate.ThreeState == false)
            {
                crujienteTotal--;
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            //semilla de girasol
            if (chbxGirasol.CheckState == CheckState.Checked)
            {
                crujienteTotal++;
                crujienteDescripcion[3] = Convert.ToString(chbxGirasol.Checked);
                //  crujienteDescripcion[3] = "Semilla de girasol";
            }
            else if (chbxGirasol.ThreeState == false)
            {
                crujienteTotal--;
            }

        }
        //INGREDIENTES PARA ADEREZOS, ELIGE HASTA 2
        private void chbxAderHke_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxAderHke.CheckState == CheckState.Checked)
            {
                aderezoTotal++;
                aderezoDescripcion[0] = Convert.ToString(chbxAderHke.Checked);               
                //aderezoDescripcion[0] = "Aderezo HKE";
            }
            else if (chbxAderHke.ThreeState == false)
            {
                aderezoTotal--;
            }
        }

        private void chbxAgridulce_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxAgridulce.CheckState == CheckState.Checked)
            {
                aderezoTotal++;
                aderezoDescripcion[1] = Convert.ToString(chbxAgridulce.Checked);                
                //aderezoDescripcion[1] = "Agridulce";
            }
            else if (chbxAgridulce.ThreeState == false)
            {
                aderezoTotal--;
            }
        }

        private void chbxSoya_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxSoya.CheckState == CheckState.Checked)
            {
                aderezoTotal++;
                aderezoDescripcion[2] = Convert.ToString(chbxSoya.Checked);              
                //aderezoDescripcion[2] = "Soya";
            }
            else if (chbxSoya.ThreeState == false)
            {
                aderezoTotal--;
            }
        }

        private void chbxAderMango_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxAderMango.CheckState == CheckState.Checked)
            {
                aderezoTotal++;
                aderezoDescripcion[3] = Convert.ToString(chbxMango.Checked);
                //aderezoDescripcion[3] = "Aderezo mango";
            }
            else if (chbxAderMango.ThreeState == false)
            {
                aderezoTotal--;
            }
        }
        //BOTON ORDENAR
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
           
            //BASE
            if (baseTotal == 1)
            {

                avisoBase.Text = "Base OK";
                avisoBase.BackColor = Color.LightGreen ;
                bAse= true;
                
                // bDesc = true;

            }
            else if (baseTotal == 0)
            {
                avisoBase.Text = "Debe elegir una base";
                avisoBase.BackColor= Color.Yellow ;
                avisoBase.ForeColor= Color.Black ;
               
            }
            else
            {
                avisoBase.Text = "Solo debe elegir una base";
                avisoBase.BackColor = Color.Red;
                
            }
            //TOPPING
            if (toppingTotal >= 1 &&  toppingTotal <= 3)
            {

                avisoTopping.Text = "Toppings OK";
                avisoTopping.BackColor = Color.LightGreen;
                topping = true;
            }
            else if (toppingTotal == 0)
            {
                avisoTopping.Text = "Debe elegir al menos  1 topping";
                avisoTopping.BackColor = Color.Yellow;
                avisoTopping.ForeColor= Color.Black ;
            }
            else
            {
                avisoTopping.Text = "Solo debe elegir 3 toppings";
                avisoTopping.BackColor = Color.Red;
                
            }
            //PROTEINA
            if (proteinaTotal >= 1 && proteinaTotal <= 2)
            {

                avisoProteina.Text = "Proteina OK";
                proteina = true;
                avisoProteina.BackColor= Color.LightGreen ;
            }
            else if (proteinaTotal == 0)
            {
                avisoProteina.Text = "Debe elegir al menos  1 proteina";
                avisoProteina.BackColor= Color.Yellow;
                avisoProteina.ForeColor= Color.Black ;
            }
            else
            {
                avisoProteina.Text = "Solo debe elegir 2 proteinas";
                avisoProteina.BackColor = Color.Red;
               
            }
            //CRUJIENTES
            if (crujienteTotal >= 1 && crujienteTotal <= 2)
            {

                avisoCrujientes.Text = "Crujiente OK";
                avisoCrujientes.BackColor= Color.LightGreen;
                crujiente = true;
            }
            else if (crujienteTotal == 0)
            {
                avisoCrujientes.Text = "Debe elegir al menos  1 crujiente";
                avisoCrujientes.BackColor= Color.Yellow;
                avisoCrujientes.ForeColor= Color.Black ;
            }
            else
            {
                avisoCrujientes.Text = "Solo debe elegir 2 crujientes";
                avisoCrujientes.BackColor= Color.Red;
                
            }
            //ADEREZOS
            if (aderezoTotal >= 1 && aderezoTotal <= 2)
            {

                avisoAderezos.Text = "Aderezo OK";
                avisoAderezos.BackColor= Color.LightGreen;
                aderezo = true;
            }
            else if (aderezoTotal == 0)
            {
                avisoAderezos.Text = "Debe elegir al menos  1 aderezo";
                avisoAderezos.BackColor= Color.Yellow;
                avisoAderezos.ForeColor= Color.Black ;
            }
            else
            {
                avisoAderezos.Text = "Solo debe elegir 2 aderezos";
                avisoAderezos.BackColor= Color.Red;
                
            }


            if (bAse == true && topping == true && proteina == true && crujiente == true && aderezo == true)
            {                   
                        MessageBox.Show("Tu orden será generada");
                       // DialogResult dialogResult = MessageBox.Show(string.Join(", ", baseTotal, baseDescripcion, toppingTotal, toppingDescripcion,
                         // proteinaTotal, proteinaDescripcion, crujienteTotal, crujienteDescripcion, aderezoTotal, aderezoDescripcion));                          
                        //Application.Exit();                                     
            }
            else
            {
                DialogResult result = MessageBox.Show("Hay un error, ¿Gusta continuar?", "¡Atención!",
               MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
                switch (result)
                {
                    case DialogResult.Yes:
                        {
                            this.Text = "[Si]";
                            break;
                        }
                    case DialogResult.No:
                        {
                            this.Text = "[No]"; Application.Exit();
                            break;
                        }
                        
                }

            }
            //resultados impresos para base
            if (chbxArroz.Checked == true && chbxFideos.Checked == false && chbxTallarines.Checked == false && chbxLechuga.Checked == false)
            {
               
                DialogResult dialogResult = MessageBox.Show("  Base: 1 de Arroz");
            }
            else if (chbxFideos.Checked == true && chbxArroz.Checked == false && chbxTallarines.Checked == false && chbxLechuga.Checked == false)
            {
                
                DialogResult dialogResult = MessageBox.Show("  Base: 1 de Fideos");
            }
            else if (chbxTallarines.Checked == true && chbxArroz.Checked == false && chbxFideos.Checked == false && chbxLechuga.Checked == false)
            {
               
                DialogResult dialogResult = MessageBox.Show("  Base: 1 de Tallarines");
            }
            else if (chbxLechuga.Checked == true && chbxArroz.Checked == false && chbxFideos.Checked == false && chbxTallarines.Checked == false)
            {
                DialogResult dialogResult = MessageBox.Show("  Base: 1 de Lechuga");

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Para que su orden este correcta, debe seleccionar 1 de Base");
            }
            //resultados impresos para Toppings
            if (chbxMango.Checked == true && chbxDurazno.Checked == true && chbxTomate.Checked == true && chbxEdemame.Checked == false && chbxMushroom.Checked==false)
            {
                
                DialogResult dialogResult = MessageBox.Show("  Topping: 1 de Mango, 1 de Durazno, 1 de Tomate");
            }
            else if (chbxMango.Checked == false && chbxDurazno.Checked == true && chbxTomate.Checked == true && chbxEdemame.Checked == true && chbxMushroom.Checked == false)
            {
                
                DialogResult dialogResult = MessageBox.Show("  Topping:  1 de Durazno, 1 de Tomate,1 de Edemame ");
            }
            else if (chbxMango.Checked == false && chbxDurazno.Checked == false && chbxTomate.Checked == true && chbxEdemame.Checked == true && chbxMushroom.Checked == true)
            {
                
                DialogResult dialogResult = MessageBox.Show("  Topping:   1 de Tomate,1 de Edemame , 1 de Mushroom");
            }
            else if (chbxMango.Checked == true && chbxDurazno.Checked == false && chbxTomate.Checked == false && chbxEdemame.Checked == true && chbxMushroom.Checked == true)
            {
                
                DialogResult dialogResult = MessageBox.Show("  Topping:   1 de Mango, 1 de Edemame , 1 de Mushroom,");
            }
            else if (chbxMango.Checked == false && chbxDurazno.Checked == true && chbxTomate.Checked == false && chbxEdemame.Checked == true && chbxMushroom.Checked == true)
            {
                
                DialogResult dialogResult = MessageBox.Show("  Topping:   1 de Durazno, 1 de Edemame , 1 de Mushroom");
            }
            else if (chbxMango.Checked == true && chbxDurazno.Checked == true && chbxTomate.Checked == false && chbxEdemame.Checked == true && chbxMushroom.Checked == false)
            {
                
                DialogResult dialogResult = MessageBox.Show("  Topping:  1 de Mango,  1 de Durazno, 1 de Edemame ,");
            }
            else if (chbxMango.Checked == false && chbxDurazno.Checked == true && chbxTomate.Checked == true && chbxEdemame.Checked == false && chbxMushroom.Checked == true)
            {
                
                DialogResult dialogResult = MessageBox.Show("  Topping:  1 de Durazno, 1 de Tomate , 1 de Mushroom");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Para que su orden este correcta, debe seleccionar 3 de Toppings");
            }
            //resultados impresos para Proteina
            if (chbxPollo.Checked == true && chbxCerdo.Checked == true && chbxRolloPri.Checked == false && chbxSurimi.Checked == false)
            {

                DialogResult dialogResult = MessageBox.Show("  Proteinas: 1 de Pollo, 1 de Cerdo");
            }
            else if (chbxPollo.Checked == false && chbxCerdo.Checked == true && chbxRolloPri.Checked == true && chbxSurimi.Checked == false)
            {

                DialogResult dialogResult = MessageBox.Show("  Proteinas:  1 de Cerdo,1 de Rollo Primavera");
            }
            else if (chbxPollo.Checked == false && chbxCerdo.Checked == false && chbxRolloPri.Checked == true && chbxSurimi.Checked == true)
            {

                DialogResult dialogResult = MessageBox.Show("  Proteinas: 1 de Rollo Primavera,  1 de Surimi");
            }
            else if (chbxPollo.Checked == true && chbxCerdo.Checked == false && chbxRolloPri.Checked == false && chbxSurimi.Checked == true)
            {

                DialogResult dialogResult = MessageBox.Show("  Proteinas: 1 de Pollo, 1 de Surimi");
            }
            else if (chbxPollo.Checked == false && chbxCerdo.Checked == true && chbxRolloPri.Checked == false && chbxSurimi.Checked == true)
            {

                DialogResult dialogResult = MessageBox.Show("  Proteinas:  1 de Cerdo, 1 de Surimi ");
            }
            else if (chbxPollo.Checked == true && chbxCerdo.Checked == false && chbxRolloPri.Checked == true && chbxSurimi.Checked == false)
            {

                DialogResult dialogResult = MessageBox.Show("  Proteinas:  1 de Pollo, 1 de Rollo Primavera ");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Para que su orden este correcta, debe seleccionar 2 de Proteinas");
            }
            //resultados impresos para Crujientes
            if (chbxArandanos.Checked == true && chbxAmaranto.Checked == true && chbxCacahuate.Checked == false && chbxGirasol.Checked == false)
            {

                DialogResult dialogResult = MessageBox.Show("  Crujientes: 1 de Arandanos, 1 de Amaranto");
            }
            else if (chbxArandanos.Checked == false && chbxAmaranto.Checked == true && chbxCacahuate.Checked == true && chbxGirasol.Checked == false)
            {

                DialogResult dialogResult = MessageBox.Show("  Crujientes:  1 de Amaranto, 1 de Cacahuates");
            }
            else if (chbxArandanos.Checked == false && chbxAmaranto.Checked == false && chbxCacahuate.Checked == true && chbxGirasol.Checked == true)
            {

                DialogResult dialogResult = MessageBox.Show("  Crujientes:  1 de Cacahuates, 1 de Semillas de Girasol");
            }
            else if (chbxArandanos.Checked == true && chbxAmaranto.Checked == false && chbxCacahuate.Checked == false && chbxGirasol.Checked == true)
            {

                DialogResult dialogResult = MessageBox.Show("  Crujientes:  1 de Arandanos, 1 de Semillas de Girasol");
            }
            else if (chbxArandanos.Checked == false && chbxAmaranto.Checked == true && chbxCacahuate.Checked == false && chbxGirasol.Checked == true)
            {

                DialogResult dialogResult = MessageBox.Show("  Crujientes:  1 de Amaranto, 1 de Semillas de Girasol");
            }
            else if (chbxArandanos.Checked == true && chbxAmaranto.Checked == false && chbxCacahuate.Checked == true && chbxGirasol.Checked == false)
            {

                DialogResult dialogResult = MessageBox.Show("  Crujientes: 1 de Arandanos,  1 de Cacahuates");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Para que su orden este correcta, debe seleccionar 2 de Crujientes");
            }
            //resultados impresos para Aderezos
            if (chbxAderHke.Checked == true && chbxAgridulce.Checked == true && chbxSoya.Checked == false && chbxAderMango.Checked == false)
            {

                DialogResult dialogResult = MessageBox.Show("  Aderezos:  1 de Aderezo HKE, 1 de Aderezo Agridulce");
            }
            else if (chbxAderHke.Checked == false && chbxAgridulce.Checked == true && chbxSoya.Checked == true && chbxAderMango.Checked == false)
            {

                DialogResult dialogResult = MessageBox.Show("  Aderezos:   1 de Aderezo Agridulce, 1 de Aderezo de Soya");
            }
            else if (chbxAderHke.Checked == false && chbxAgridulce.Checked == false && chbxSoya.Checked == true && chbxAderMango.Checked == true)
            {

                DialogResult dialogResult = MessageBox.Show("  Aderezos:  1 de Aderezo de Soya, 1 de Aderezo Mango");
            }
            else if (chbxAderHke.Checked == true && chbxAgridulce.Checked == false && chbxSoya.Checked == false && chbxAderMango.Checked == true)
            {

                DialogResult dialogResult = MessageBox.Show("  Aderezos:  1 de Aderezo HKE, 1 de Aderezo de Mango");
            }
            else if (chbxAderHke.Checked == false && chbxAgridulce.Checked == true && chbxSoya.Checked == false && chbxAderMango.Checked == true)
            {

                DialogResult dialogResult = MessageBox.Show("  Aderezos:   1 de Aderezo Agridulce, 1 de Aderezo de Mango");
            }
            else if (chbxAderHke.Checked == true && chbxAgridulce.Checked == false && chbxSoya.Checked == false && chbxAderMango.Checked == true)
            {

                DialogResult dialogResult = MessageBox.Show("  Aderezos:  1 de Aderezo HKE, 1 de Aderezo Soya");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Para que su orden este correcta, debe seleccionar 2 de Aderezos");
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("¿Desea salir?", "Perla's Food",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        private void ResetCheckBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (Controls) =>
            {
                foreach (Control control in Controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else func(control.Controls);

            };
            func(Controls);
        }
        private void ResetTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (Controls) =>
            {
                foreach (Control control in Controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else func(control.Controls);

            };
            func(Controls);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetCheckBoxes();
            ResetTextBoxes();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ordenBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
