using ProyectoNuevoRegistro.DAL;
using ProyectoNuevoRegistro.BLL;
using ProyectoNuevoRegistro.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoNuevoRegistro
{
    public partial class rUsuarios : Form
    {
        public rUsuarios()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IDNumericUpDown1.Value = 0;
            NombresTextBox.Clear();
            AliasTextBox.Clear();
            ClaveConfirmTextBox.Clear();
            EmailTextBox.Clear();
            errorProvider1.Clear();
            FechaDateTimePicker.CustomFormat = " ";
            ClaveTextBox.Clear();
            ActivoCheckBox.Checked = false;
            RolComboBox.Text = " ";
        }

        private void LlenaCampo(Usuarios usuarios)
        {
            IDNumericUpDown1.Value = usuarios.UsuarioId; 
            NombresTextBox.Text = usuarios.Nombres;
            EmailTextBox.Text = usuarios.Email;
            AliasTextBox.Text = usuarios.Alias;
            RolComboBox.Text = usuarios.DescripcionRol;
            ClaveTextBox.Text = usuarios.Clave;
            FechaDateTimePicker.Value = usuarios.FechaIngreso;
            ActivoCheckBox.Checked = usuarios.Activo;
            ClaveConfirmTextBox.Text = usuarios.Clave;
        }

        private Usuarios LlenaClase()
        {
            Usuarios usuarios = new Usuarios();
            usuarios.UsuarioId = (int)IDNumericUpDown1.Value;
            usuarios.Clave = ClaveTextBox.Text;
            usuarios.Email = EmailTextBox.Text;
            usuarios.Nombres = NombresTextBox.Text;           
            usuarios.FechaIngreso = FechaDateTimePicker.Value;
            usuarios.Alias = AliasTextBox.Text;
            usuarios.DescripcionRol = RolComboBox.Text;
            usuarios.Activo = ActivoCheckBox.Checked;

            return usuarios;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Usuarios usuarios = UsuariosBLL.Buscar((int)IDNumericUpDown1.Value);

            return (usuarios != null);
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Usuarios usuarios;
            bool paso = false;

            if (!Validar())
                return;

            usuarios = LlenaClase();

            if (!(UsuariosBLL.Existe((int)IDNumericUpDown1.Value)))
            {
                if (!ExisteEnLaBaseDeDatos())
                    paso = UsuariosBLL.Guardar(usuarios);
                else
                {
                    paso = UsuariosBLL.Modificar(usuarios);
                }
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validar()
        {
            bool paso = true;

            if (NombresTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(NombresTextBox, "El campo nombre no puede estar vacio");
                NombresTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                errorProvider1.SetError(EmailTextBox, "El Email no puede estar vacio");
                EmailTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(AliasTextBox.Text))
            {
                errorProvider1.SetError(AliasTextBox, "El campo Alias no puede estar vacio");
                AliasTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(RolComboBox.Text))
            {
                errorProvider1.SetError(RolComboBox, "Debe agregar un rol especifico");
                RolComboBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ClaveTextBox.Text))
            {
                errorProvider1.SetError(ClaveTextBox, "Debe asignar una clave a su usuario");
                ClaveTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ClaveConfirmTextBox.Text))
            {
                errorProvider1.SetError(ClaveConfirmTextBox, "Debe confirmar la clave");
                ClaveConfirmTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(FechaDateTimePicker.Text))
            {
                errorProvider1.SetError(FechaDateTimePicker, "Debe agregar una fecha de registro");
                FechaDateTimePicker.Focus();
                paso = false;
            }
            if(ClaveTextBox.Text != ClaveConfirmTextBox.Text)
            {
                MessageBox.Show("La contraseña debe ser igual para ambos casos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                paso = false;
            }
            return paso;
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            int id;
            int.TryParse(IDNumericUpDown1.Text, out id);

            Limpiar();

            if (UsuariosBLL.Eliminar(id))
                MessageBox.Show("Eliminado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                errorProvider1.SetError(IDNumericUpDown1, "No se puede eliminar una persona que no existe");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FechaDateTimePicker.CustomFormat = "dd / MM / yyyy";
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            int id;
            Usuarios usuario = new Usuarios();
            int.TryParse(IDNumericUpDown1.Text, out id);

            Limpiar();

            usuario = UsuariosBLL.Buscar(id);

            if (usuario != null)
            {
                MessageBox.Show("Persona Encotrada","Exito",MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenaCampo(usuario);
            }
            else
            {
                MessageBox.Show("Persona no Encontrada","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void textBoxClave_TextChanged(object sender, EventArgs e)
        {
            ClaveTextBox.PasswordChar = '*';
        }

        private void textBoxClaveConfirm_TextChanged(object sender, EventArgs e)
        {
            ClaveConfirmTextBox.PasswordChar = '*';
        }
    }
}
