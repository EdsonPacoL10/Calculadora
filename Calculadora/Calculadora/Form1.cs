namespace Calculadora
{
    public partial class Form1 : Form
    {
        string operador;
        double num1;
        double num2;
        double res;
        int i = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text+"0";
        }

        private void bot_1_Click(object sender, EventArgs e)
        {
      
                pantalla.Text = pantalla.Text + "1";
             
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text+ "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text+ "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text+"4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text+ "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text+ "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text+ "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text+"8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text+"9";
        }

        private void btn_punto_Click(object sender, EventArgs e)
        {
         
            if (i==1)
            {
                pantalla.Text = pantalla.Text + ",";
                i=0;
            }
            else
            {
                MessageBox.Show("EN UNA OPERACION ARITMETICA SOLO SE USA UNA COMA PARA EL DECIMAL");
            }
            
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void btn_renover_Click(object sender, EventArgs e)
        {
          
            
            if (pantalla.TextLength>1)
            {
                pantalla.Text = pantalla.Text.Remove(pantalla.Text.Length -1, 1);

            }
        }

        private void btn_mas_Click(object sender, EventArgs e)
        {
            i = 1;
            if (!string.IsNullOrEmpty(pantalla.Text))
            {
                operador = "+";
                num1 = Double.Parse(pantalla.Text);//convcierte un texto a numero(decimal o double)
                pantalla.Clear();
                // pantalla.Text = num1.ToString();//convierte un numero a texto
            }
            else { MessageBox.Show("DAR VALOR PORFAVOR NO SE PUEDE REALIZAR LA OPERACION"); }
        }

        private void btn_menos_Click(object sender, EventArgs e)
        {
            i = 1;
            if (!string.IsNullOrEmpty(pantalla.Text))
            {

                operador = "-";
                num1 = Double.Parse(pantalla.Text);//convcierte un texto a numero(decimal o double)
                pantalla.Clear();
                // pantalla.Text = num1.ToString();//convierte un numero a texto
            }
            else { MessageBox.Show("DAR VALOR PORFAVOR NO SE PUEDE REALIZAR LA OPERACION"); }
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(pantalla.Text))
            {
               

        num2 = Double.Parse(pantalla.Text);
            switch (operador)
            {
                case "+":
                    res=num1 + num2;
                    break;
                case "-":
                    res=num2 - num1;
                    break;
                case "X":
                    res=num1 * num2;
                    break;
                case "/":
                    res=num1 / num2;
                    break;

            }
            pantalla.Text= res.ToString();
            pan_ope.Text = num1.ToString() + operador + num2.ToString();
            }
            else
            {
                MessageBox.Show("DAR VALOR PORFAVOR NO SE PUEDE REALIZAR LA OPERACION");
            }

        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            i = 1;
            if (!string.IsNullOrEmpty(pantalla.Text))
            {

                operador = "X";
                num1 = Double.Parse(pantalla.Text);//convcierte un texto a numero(decimal o double)
                pantalla.Clear();
                // pantalla.Text = num1.ToString();//convierte un numero a texto
            }
            else { MessageBox.Show("DAR VALOR PORFAVOR NO SE PUEDE REALIZAR LA OPERACION"); }
        

       
        }

        private void btn_divi_Click(object sender, EventArgs e)
        {
            i = 1;
            if (!string.IsNullOrEmpty(pantalla.Text))
            {
                operador = "/";
                num1 = Double.Parse(pantalla.Text);//convcierte un texto a numero(decimal o double)
                pantalla.Clear();
                // pantalla.Text = num1.ToString();//convierte un numero a texto
            }
            else { MessageBox.Show("DAR VALOR PORFAVOR NO SE PUEDE REALIZAR LA OPERACION"); }




        }

        private void bot_mas_menos_Click(object sender, EventArgs e)
        {
            if (num1.ToString() == "0")
            {
                MessageBox.Show("DAR PRIMER VALOR PARA ESTA OPCION");
            }
            else { 
                res = res * -1;
               
                pantalla.Text = res.ToString();
             
            }
            
            }

        private void bot_ce_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ADIOS QUE TENGA UN BONITO DIA :)");
            Close();    
        }
    }
}