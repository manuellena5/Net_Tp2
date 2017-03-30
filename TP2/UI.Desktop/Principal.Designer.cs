namespace UI.Desktop
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.SyscadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.altaPersonaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.altaUsuarioMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.carreraMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.planesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuComisiones = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.InscripcionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cursarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aCursadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comisionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HerramientaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarBackUpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarBackUpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Conectado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SyscadMenu,
            this.PersonaMenu,
            this.carreraMenu,
            this.InscripcionMenu,
            this.ConsultaMenu,
            this.HerramientaMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.HerramientaMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // SyscadMenu
            // 
            this.SyscadMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalirMenu});
            this.SyscadMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.SyscadMenu.Name = "SyscadMenu";
            this.SyscadMenu.Size = new System.Drawing.Size(123, 20);
            this.SyscadMenu.Text = "&Sistema Academico";
            // 
            // SalirMenu
            // 
            this.SalirMenu.Name = "SalirMenu";
            this.SalirMenu.Size = new System.Drawing.Size(96, 22);
            this.SalirMenu.Text = "&Salir";
            this.SalirMenu.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // PersonaMenu
            // 
            this.PersonaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaPersonaMenu,
            this.altaUsuarioMenu});
            this.PersonaMenu.Name = "PersonaMenu";
            this.PersonaMenu.Size = new System.Drawing.Size(109, 20);
            this.PersonaMenu.Text = "Gestion personas";
            this.PersonaMenu.Click += new System.EventHandler(this.PersonaMenu_Click);
            // 
            // altaPersonaMenu
            // 
            this.altaPersonaMenu.Name = "altaPersonaMenu";
            this.altaPersonaMenu.Size = new System.Drawing.Size(145, 22);
            this.altaPersonaMenu.Text = "ABM Persona";
            this.altaPersonaMenu.Click += new System.EventHandler(this.altaPersonaMenu_Click);
            // 
            // altaUsuarioMenu
            // 
            this.altaUsuarioMenu.Name = "altaUsuarioMenu";
            this.altaUsuarioMenu.Size = new System.Drawing.Size(145, 22);
            this.altaUsuarioMenu.Text = "ABM Usuario";
            this.altaUsuarioMenu.Click += new System.EventHandler(this.altaUsuarioToolStripMenuItem_Click);
            // 
            // carreraMenu
            // 
            this.carreraMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.especialidadesMenu,
            this.planesMenu,
            this.materiasMenu,
            this.mnuComisiones,
            this.mnuCursos});
            this.carreraMenu.Name = "carreraMenu";
            this.carreraMenu.Size = new System.Drawing.Size(103, 20);
            this.carreraMenu.Text = "Gestion carreras";
            this.carreraMenu.Click += new System.EventHandler(this.carreraMenu_Click);
            // 
            // especialidadesMenu
            // 
            this.especialidadesMenu.Name = "especialidadesMenu";
            this.especialidadesMenu.Size = new System.Drawing.Size(179, 22);
            this.especialidadesMenu.Text = "ABM Especialidades";
            this.especialidadesMenu.Click += new System.EventHandler(this.especialidadesMenu_Click);
            // 
            // planesMenu
            // 
            this.planesMenu.Name = "planesMenu";
            this.planesMenu.Size = new System.Drawing.Size(179, 22);
            this.planesMenu.Text = "ABM Planes";
            this.planesMenu.Click += new System.EventHandler(this.planesMenu_Click);
            // 
            // materiasMenu
            // 
            this.materiasMenu.Name = "materiasMenu";
            this.materiasMenu.Size = new System.Drawing.Size(179, 22);
            this.materiasMenu.Text = "ABM Materias";
            this.materiasMenu.Click += new System.EventHandler(this.materiasMenu_Click);
            // 
            // mnuComisiones
            // 
            this.mnuComisiones.Name = "mnuComisiones";
            this.mnuComisiones.Size = new System.Drawing.Size(179, 22);
            this.mnuComisiones.Text = "ABM Comisiones";
            this.mnuComisiones.Click += new System.EventHandler(this.mnuComisiones_Click);
            // 
            // mnuCursos
            // 
            this.mnuCursos.Name = "mnuCursos";
            this.mnuCursos.Size = new System.Drawing.Size(179, 22);
            this.mnuCursos.Text = "ABM Cursos";
            this.mnuCursos.Click += new System.EventHandler(this.mnuCursos_Click);
            // 
            // InscripcionMenu
            // 
            this.InscripcionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursarMenu,
            this.materiasToolStripMenuItem1,
            this.aCursadoToolStripMenuItem});
            this.InscripcionMenu.Name = "InscripcionMenu";
            this.InscripcionMenu.Size = new System.Drawing.Size(72, 20);
            this.InscripcionMenu.Text = "&Incripcion";
            this.InscripcionMenu.Click += new System.EventHandler(this.viewMenu_Click);
            // 
            // cursarMenu
            // 
            this.cursarMenu.Name = "cursarMenu";
            this.cursarMenu.Size = new System.Drawing.Size(249, 22);
            this.cursarMenu.Text = "Manejo de inscripciones (Admin)";
            this.cursarMenu.Click += new System.EventHandler(this.cursarMenu_Click);
            // 
            // materiasToolStripMenuItem1
            // 
            this.materiasToolStripMenuItem1.Name = "materiasToolStripMenuItem1";
            this.materiasToolStripMenuItem1.Size = new System.Drawing.Size(249, 22);
            this.materiasToolStripMenuItem1.Text = "A Examen";
            this.materiasToolStripMenuItem1.Click += new System.EventHandler(this.materiasToolStripMenuItem1_Click);
            // 
            // aCursadoToolStripMenuItem
            // 
            this.aCursadoToolStripMenuItem.Name = "aCursadoToolStripMenuItem";
            this.aCursadoToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.aCursadoToolStripMenuItem.Text = "A cursado";
            this.aCursadoToolStripMenuItem.Click += new System.EventHandler(this.aCursadoToolStripMenuItem_Click);
            // 
            // ConsultaMenu
            // 
            this.ConsultaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materiasToolStripMenuItem,
            this.planesToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.comisionesToolStripMenuItem,
            this.alumnosToolStripMenuItem,
            this.personasToolStripMenuItem,
            this.miEstadoToolStripMenuItem});
            this.ConsultaMenu.Name = "ConsultaMenu";
            this.ConsultaMenu.Size = new System.Drawing.Size(70, 20);
            this.ConsultaMenu.Text = "&Consultar";
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.materiasToolStripMenuItem.Text = "Materias";
            this.materiasToolStripMenuItem.Click += new System.EventHandler(this.materiasToolStripMenuItem_Click);
            // 
            // planesToolStripMenuItem
            // 
            this.planesToolStripMenuItem.Name = "planesToolStripMenuItem";
            this.planesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.planesToolStripMenuItem.Text = "Planes";
            this.planesToolStripMenuItem.Click += new System.EventHandler(this.planesToolStripMenuItem_Click);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.cursosToolStripMenuItem.Text = "Cursos";
            this.cursosToolStripMenuItem.Click += new System.EventHandler(this.cursosToolStripMenuItem_Click);
            // 
            // comisionesToolStripMenuItem
            // 
            this.comisionesToolStripMenuItem.Name = "comisionesToolStripMenuItem";
            this.comisionesToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.comisionesToolStripMenuItem.Text = "Comisiones";
            this.comisionesToolStripMenuItem.Click += new System.EventHandler(this.comisionesToolStripMenuItem_Click);
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.alumnosToolStripMenuItem_Click);
            // 
            // personasToolStripMenuItem
            // 
            this.personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            this.personasToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.personasToolStripMenuItem.Text = "Personas";
            this.personasToolStripMenuItem.Click += new System.EventHandler(this.personasToolStripMenuItem_Click);
            // 
            // miEstadoToolStripMenuItem
            // 
            this.miEstadoToolStripMenuItem.Name = "miEstadoToolStripMenuItem";
            this.miEstadoToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.miEstadoToolStripMenuItem.Text = "Mi Estado";
            this.miEstadoToolStripMenuItem.Click += new System.EventHandler(this.miEstadoToolStripMenuItem_Click);
            // 
            // HerramientaMenu
            // 
            this.HerramientaMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.HerramientaMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HerramientaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarBackUpMenu,
            this.restaurarBackUpMenu});
            this.HerramientaMenu.ForeColor = System.Drawing.Color.Black;
            this.HerramientaMenu.Name = "HerramientaMenu";
            this.HerramientaMenu.Size = new System.Drawing.Size(90, 20);
            this.HerramientaMenu.Text = "&Herramientas";
            // 
            // realizarBackUpMenu
            // 
            this.realizarBackUpMenu.Name = "realizarBackUpMenu";
            this.realizarBackUpMenu.Size = new System.Drawing.Size(169, 22);
            this.realizarBackUpMenu.Text = "Realizar Back Up";
            // 
            // restaurarBackUpMenu
            // 
            this.restaurarBackUpMenu.Name = "restaurarBackUpMenu";
            this.restaurarBackUpMenu.Size = new System.Drawing.Size(169, 22);
            this.restaurarBackUpMenu.Text = "Restaurar Back Up";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(53, 20);
            this.helpMenu.Text = "Ay&uda";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.contentsToolStripMenuItem.Text = "&Contenido";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.indexToolStripMenuItem.Text = "&Índice";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.searchToolStripMenuItem.Text = "&Buscar";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(173, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.aboutToolStripMenuItem.Text = "&Acerca de... ...";
            // 
            // toolStrip
            // 
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(632, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.Conectado});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            this.statusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip_ItemClicked);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // Conectado
            // 
            this.Conectado.Name = "Conectado";
            this.Conectado.Size = new System.Drawing.Size(0, 17);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Desktop.Properties.Resources.images__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SyscadMenu;
        private System.Windows.Forms.ToolStripMenuItem SalirMenu;
        private System.Windows.Forms.ToolStripMenuItem PersonaMenu;
        private System.Windows.Forms.ToolStripMenuItem InscripcionMenu;
        private System.Windows.Forms.ToolStripMenuItem ConsultaMenu;
        private System.Windows.Forms.ToolStripMenuItem HerramientaMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem altaPersonaMenu;
        private System.Windows.Forms.ToolStripMenuItem altaUsuarioMenu;
        private System.Windows.Forms.ToolStripMenuItem cursarMenu;
        private System.Windows.Forms.ToolStripMenuItem realizarBackUpMenu;
        private System.Windows.Forms.ToolStripMenuItem restaurarBackUpMenu;
        private System.Windows.Forms.ToolStripMenuItem carreraMenu;
        private System.Windows.Forms.ToolStripMenuItem especialidadesMenu;
        private System.Windows.Forms.ToolStripMenuItem planesMenu;
        private System.Windows.Forms.ToolStripMenuItem materiasMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuComisiones;
        private System.Windows.Forms.ToolStripStatusLabel Conectado;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comisionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCursos;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aCursadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miEstadoToolStripMenuItem;
    }
}



