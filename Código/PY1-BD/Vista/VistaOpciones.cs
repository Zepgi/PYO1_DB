//CÓDIGO EYDEN SU

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PY1_BD.Vista {
	public partial class VistaOpciones : Form {

		public bool esAdmin;
		public int idUsuario;
		private string active;
		public VistaOpciones(bool pEsAdmin, int pIdUsuario) {
			this.esAdmin = pEsAdmin;
			this.idUsuario = pIdUsuario;
			this.active = null;
			
			InitializeComponent();
			this.btAdd.Visible = false;
			this.btMod.Visible = false;
			this.btDel.Visible = false;
		}

		public void setActive(String pActive) {
			this.active = pActive;
		}

		public String getActive() {
			return this.active;
		}
	}
}
