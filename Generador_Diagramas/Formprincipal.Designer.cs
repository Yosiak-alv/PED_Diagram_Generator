﻿namespace Generador_Diagramas
{
    partial class Formprincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formprincipal));
            this.BTNArchivo = new FontAwesome.Sharp.IconButton();
            this.ActualSeleccionbox = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnexit = new FontAwesome.Sharp.IconButton();
            this.panelInvocarForms = new System.Windows.Forms.Panel();
            this.panelProperties = new System.Windows.Forms.Panel();
            this.GridPropiedades = new System.Windows.Forms.PropertyGrid();
            this.panelfig = new System.Windows.Forms.Panel();
            this.TabCTR = new System.Windows.Forms.TabControl();
            this.Figuras = new System.Windows.Forms.TabPage();
            this.lstNODOList = new System.Windows.Forms.ListBox();
            this.Conectores = new System.Windows.Forms.TabPage();
            this.lstFlechasConectors = new System.Windows.Forms.ListBox();
            this.CBMTipoFlechaConectors = new System.Windows.Forms.ComboBox();
            this.DiagramaVer = new MindFusion.Diagramming.WinForms.DiagramView();
            this.Diagrama = new MindFusion.Diagramming.Diagram();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.SubmenuInformacion = new System.Windows.Forms.Panel();
            this.BTNAcerca = new FontAwesome.Sharp.IconButton();
            this.BTNINFO = new FontAwesome.Sharp.IconButton();
            this.SubmenuConvertir = new System.Windows.Forms.Panel();
            this.BTNImprimir = new FontAwesome.Sharp.IconButton();
            this.BTNPNG = new FontAwesome.Sharp.IconButton();
            this.BTNSVG = new FontAwesome.Sharp.IconButton();
            this.BTNPDF = new FontAwesome.Sharp.IconButton();
            this.btnConvertir = new FontAwesome.Sharp.IconButton();
            this.SubmenuEditar = new System.Windows.Forms.Panel();
            this.BtnDeshacer = new FontAwesome.Sharp.IconButton();
            this.btnRehacer = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.SubmenuArchivo = new System.Windows.Forms.Panel();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnAbrir = new FontAwesome.Sharp.IconButton();
            this.btnnuevo = new FontAwesome.Sharp.IconButton();
            this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.hidden = new MindFusion.Diagramming.Diagram();
            this.ContextMenu = new System.Windows.Forms.ContextMenu();
            this._menuItemDelete = new System.Windows.Forms.MenuItem();
            this.panelsidebar.SuspendLayout();
            this.paneltop.SuspendLayout();
            this.panelfill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActualSeleccionbox)).BeginInit();
            this.panelInvocarForms.SuspendLayout();
            this.panelProperties.SuspendLayout();
            this.panelfig.SuspendLayout();
            this.TabCTR.SuspendLayout();
            this.Figuras.SuspendLayout();
            this.Conectores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLogo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SubmenuInformacion.SuspendLayout();
            this.SubmenuConvertir.SuspendLayout();
            this.SubmenuEditar.SuspendLayout();
            this.SubmenuArchivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelsidebar
            // 
            this.panelsidebar.Controls.Add(this.panelMenu);
            this.panelsidebar.Controls.Add(this.panelLogo);
            this.panelsidebar.Size = new System.Drawing.Size(283, 939);
            // 
            // paneltop
            // 
            this.paneltop.Controls.Add(this.label1);
            this.paneltop.Controls.Add(this.ActualSeleccionbox);
            this.paneltop.Size = new System.Drawing.Size(1115, 89);
            // 
            // panelfill
            // 
            this.panelfill.Controls.Add(this.panelInvocarForms);
            this.panelfill.Location = new System.Drawing.Point(283, 89);
            this.panelfill.Size = new System.Drawing.Size(1115, 850);
            // 
            // BTNArchivo
            // 
            this.BTNArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BTNArchivo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNArchivo.FlatAppearance.BorderSize = 0;
            this.BTNArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNArchivo.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNArchivo.ForeColor = System.Drawing.Color.Gainsboro;
            this.BTNArchivo.IconChar = FontAwesome.Sharp.IconChar.File;
            this.BTNArchivo.IconColor = System.Drawing.Color.Gainsboro;
            this.BTNArchivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTNArchivo.IconSize = 36;
            this.BTNArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNArchivo.Location = new System.Drawing.Point(0, 0);
            this.BTNArchivo.Name = "BTNArchivo";
            this.BTNArchivo.Size = new System.Drawing.Size(283, 61);
            this.BTNArchivo.TabIndex = 19;
            this.BTNArchivo.Text = "Archivo";
            this.BTNArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNArchivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNArchivo.UseVisualStyleBackColor = false;
            this.BTNArchivo.Click += new System.EventHandler(this.BTNArchivo_Click);
            // 
            // ActualSeleccionbox
            // 
            this.ActualSeleccionbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ActualSeleccionbox.ForeColor = System.Drawing.Color.Gainsboro;
            this.ActualSeleccionbox.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ActualSeleccionbox.IconColor = System.Drawing.Color.Gainsboro;
            this.ActualSeleccionbox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ActualSeleccionbox.Location = new System.Drawing.Point(18, 36);
            this.ActualSeleccionbox.Name = "ActualSeleccionbox";
            this.ActualSeleccionbox.Size = new System.Drawing.Size(32, 32);
            this.ActualSeleccionbox.TabIndex = 7;
            this.ActualSeleccionbox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Home";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnexit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnexit.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnexit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnexit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnexit.IconSize = 36;
            this.btnexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexit.Location = new System.Drawing.Point(0, 706);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(283, 61);
            this.btnexit.TabIndex = 21;
            this.btnexit.Text = "Salir";
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // panelInvocarForms
            // 
            this.panelInvocarForms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInvocarForms.Controls.Add(this.panelProperties);
            this.panelInvocarForms.Controls.Add(this.panelfig);
            this.panelInvocarForms.Controls.Add(this.DiagramaVer);
            this.panelInvocarForms.Location = new System.Drawing.Point(18, 19);
            this.panelInvocarForms.Name = "panelInvocarForms";
            this.panelInvocarForms.Size = new System.Drawing.Size(1081, 820);
            this.panelInvocarForms.TabIndex = 0;
            // 
            // panelProperties
            // 
            this.panelProperties.Controls.Add(this.GridPropiedades);
            this.panelProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProperties.Location = new System.Drawing.Point(0, 444);
            this.panelProperties.Name = "panelProperties";
            this.panelProperties.Size = new System.Drawing.Size(379, 376);
            this.panelProperties.TabIndex = 10;
            // 
            // GridPropiedades
            // 
            this.GridPropiedades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridPropiedades.Location = new System.Drawing.Point(0, 0);
            this.GridPropiedades.Name = "GridPropiedades";
            this.GridPropiedades.Size = new System.Drawing.Size(379, 376);
            this.GridPropiedades.TabIndex = 1;
            this.GridPropiedades.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.PropiedadEditChange);
            // 
            // panelfig
            // 
            this.panelfig.Controls.Add(this.TabCTR);
            this.panelfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelfig.Location = new System.Drawing.Point(0, 0);
            this.panelfig.Name = "panelfig";
            this.panelfig.Size = new System.Drawing.Size(379, 444);
            this.panelfig.TabIndex = 9;
            // 
            // TabCTR
            // 
            this.TabCTR.Controls.Add(this.Figuras);
            this.TabCTR.Controls.Add(this.Conectores);
            this.TabCTR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabCTR.Location = new System.Drawing.Point(0, 0);
            this.TabCTR.Name = "TabCTR";
            this.TabCTR.SelectedIndex = 0;
            this.TabCTR.Size = new System.Drawing.Size(379, 444);
            this.TabCTR.TabIndex = 1;
            // 
            // Figuras
            // 
            this.Figuras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.Figuras.Controls.Add(this.lstNODOList);
            this.Figuras.Location = new System.Drawing.Point(4, 22);
            this.Figuras.Name = "Figuras";
            this.Figuras.Padding = new System.Windows.Forms.Padding(3);
            this.Figuras.Size = new System.Drawing.Size(371, 418);
            this.Figuras.TabIndex = 0;
            this.Figuras.Text = "Figuras";
            // 
            // lstNODOList
            // 
            this.lstNODOList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstNODOList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstNODOList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lstNODOList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstNODOList.Location = new System.Drawing.Point(3, 3);
            this.lstNODOList.Name = "lstNODOList";
            this.lstNODOList.Size = new System.Drawing.Size(365, 412);
            this.lstNODOList.Sorted = true;
            this.lstNODOList.TabIndex = 8;
            this.lstNODOList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstNODOList_DrawItem);
            this.lstNODOList.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lstFlechasConectors_MeasureItem);
            this.lstNODOList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstNODOList_MouseDown);
            // 
            // Conectores
            // 
            this.Conectores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.Conectores.Controls.Add(this.lstFlechasConectors);
            this.Conectores.Controls.Add(this.CBMTipoFlechaConectors);
            this.Conectores.Location = new System.Drawing.Point(4, 22);
            this.Conectores.Name = "Conectores";
            this.Conectores.Padding = new System.Windows.Forms.Padding(3);
            this.Conectores.Size = new System.Drawing.Size(77, 418);
            this.Conectores.TabIndex = 1;
            this.Conectores.Text = "Conectores";
            // 
            // lstFlechasConectors
            // 
            this.lstFlechasConectors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstFlechasConectors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFlechasConectors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lstFlechasConectors.Location = new System.Drawing.Point(3, 3);
            this.lstFlechasConectors.Name = "lstFlechasConectors";
            this.lstFlechasConectors.Size = new System.Drawing.Size(71, 391);
            this.lstFlechasConectors.TabIndex = 4;
            this.lstFlechasConectors.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstFlechasConectors_DrawItem);
            this.lstFlechasConectors.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lstFlechasConectors_MeasureItem);
            this.lstFlechasConectors.SelectedIndexChanged += new System.EventHandler(this.lstFlechasConectors_SelectedIndexChanged);
            // 
            // CBMTipoFlechaConectors
            // 
            this.CBMTipoFlechaConectors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CBMTipoFlechaConectors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMTipoFlechaConectors.Items.AddRange(new object[] {
            "Linea Recta",
            "Linea Curva",
            "Linea Perpendicular"});
            this.CBMTipoFlechaConectors.Location = new System.Drawing.Point(3, 394);
            this.CBMTipoFlechaConectors.Name = "CBMTipoFlechaConectors";
            this.CBMTipoFlechaConectors.Size = new System.Drawing.Size(71, 21);
            this.CBMTipoFlechaConectors.TabIndex = 3;
            this.CBMTipoFlechaConectors.SelectedValueChanged += new System.EventHandler(this.CBMTipoFlechaConectors_SelectedValueChanged);
            // 
            // DiagramaVer
            // 
            this.DiagramaVer.AllowDrop = true;
            this.DiagramaVer.Behavior = MindFusion.Diagramming.Behavior.DrawLinks;
            this.DiagramaVer.Diagram = this.Diagrama;
            this.DiagramaVer.Dock = System.Windows.Forms.DockStyle.Right;
            this.DiagramaVer.LicenseKey = null;
            this.DiagramaVer.Location = new System.Drawing.Point(379, 0);
            this.DiagramaVer.Name = "DiagramaVer";
            this.DiagramaVer.Size = new System.Drawing.Size(702, 820);
            this.DiagramaVer.TabIndex = 8;
            this.DiagramaVer.Text = "DiagramaVer";
            this.DiagramaVer.DragDrop += new System.Windows.Forms.DragEventHandler(this.DiagramaVer_DragDrop);
            this.DiagramaVer.DragOver += new System.Windows.Forms.DragEventHandler(this.DiagramaVer_DragOver);
            // 
            // Diagrama
            // 
            this.Diagrama.TouchThreshold = 0F;
            this.Diagrama.LinkClicked += new System.EventHandler<MindFusion.Diagramming.LinkEventArgs>(this.Diagrama_LinkClicked);
            this.Diagrama.NodeActivated += new System.EventHandler<MindFusion.Diagramming.NodeEventArgs>(this.Diagrama_NodeActivated);
            this.Diagrama.NodeClicked += new System.EventHandler<MindFusion.Diagramming.NodeEventArgs>(this.Diagrama_NodeClicked);
            this.Diagrama.NodeDeactivated += new System.EventHandler<MindFusion.Diagramming.NodeEventArgs>(this.Diagrama_NodeDeactivated);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(283, 173);
            this.panelLogo.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnexit);
            this.panelMenu.Controls.Add(this.SubmenuInformacion);
            this.panelMenu.Controls.Add(this.BTNINFO);
            this.panelMenu.Controls.Add(this.SubmenuConvertir);
            this.panelMenu.Controls.Add(this.btnConvertir);
            this.panelMenu.Controls.Add(this.SubmenuEditar);
            this.panelMenu.Controls.Add(this.btnEditar);
            this.panelMenu.Controls.Add(this.SubmenuArchivo);
            this.panelMenu.Controls.Add(this.BTNArchivo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 173);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(283, 766);
            this.panelMenu.TabIndex = 1;
            // 
            // SubmenuInformacion
            // 
            this.SubmenuInformacion.BackColor = System.Drawing.Color.White;
            this.SubmenuInformacion.Controls.Add(this.BTNAcerca);
            this.SubmenuInformacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubmenuInformacion.Location = new System.Drawing.Point(0, 659);
            this.SubmenuInformacion.Name = "SubmenuInformacion";
            this.SubmenuInformacion.Size = new System.Drawing.Size(283, 47);
            this.SubmenuInformacion.TabIndex = 26;
            // 
            // BTNAcerca
            // 
            this.BTNAcerca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BTNAcerca.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNAcerca.FlatAppearance.BorderSize = 0;
            this.BTNAcerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNAcerca.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAcerca.ForeColor = System.Drawing.Color.Gainsboro;
            this.BTNAcerca.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.BTNAcerca.IconColor = System.Drawing.Color.Gainsboro;
            this.BTNAcerca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTNAcerca.IconSize = 36;
            this.BTNAcerca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNAcerca.Location = new System.Drawing.Point(0, 0);
            this.BTNAcerca.Name = "BTNAcerca";
            this.BTNAcerca.Size = new System.Drawing.Size(283, 47);
            this.BTNAcerca.TabIndex = 28;
            this.BTNAcerca.Text = "Acerca de Diagramonus";
            this.BTNAcerca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNAcerca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNAcerca.UseVisualStyleBackColor = false;
            this.BTNAcerca.Click += new System.EventHandler(this.BTNAcerca_Click);
            // 
            // BTNINFO
            // 
            this.BTNINFO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BTNINFO.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNINFO.FlatAppearance.BorderSize = 0;
            this.BTNINFO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNINFO.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNINFO.ForeColor = System.Drawing.Color.Gainsboro;
            this.BTNINFO.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.BTNINFO.IconColor = System.Drawing.Color.Gainsboro;
            this.BTNINFO.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTNINFO.IconSize = 36;
            this.BTNINFO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNINFO.Location = new System.Drawing.Point(0, 598);
            this.BTNINFO.Name = "BTNINFO";
            this.BTNINFO.Size = new System.Drawing.Size(283, 61);
            this.BTNINFO.TabIndex = 25;
            this.BTNINFO.Text = "Informacion";
            this.BTNINFO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNINFO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNINFO.UseVisualStyleBackColor = false;
            this.BTNINFO.Click += new System.EventHandler(this.BTNINFO_Click);
            // 
            // SubmenuConvertir
            // 
            this.SubmenuConvertir.BackColor = System.Drawing.Color.White;
            this.SubmenuConvertir.Controls.Add(this.BTNImprimir);
            this.SubmenuConvertir.Controls.Add(this.BTNPNG);
            this.SubmenuConvertir.Controls.Add(this.BTNSVG);
            this.SubmenuConvertir.Controls.Add(this.BTNPDF);
            this.SubmenuConvertir.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubmenuConvertir.Location = new System.Drawing.Point(0, 410);
            this.SubmenuConvertir.Name = "SubmenuConvertir";
            this.SubmenuConvertir.Size = new System.Drawing.Size(283, 188);
            this.SubmenuConvertir.TabIndex = 24;
            // 
            // BTNImprimir
            // 
            this.BTNImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BTNImprimir.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNImprimir.FlatAppearance.BorderSize = 0;
            this.BTNImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNImprimir.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNImprimir.ForeColor = System.Drawing.Color.Gainsboro;
            this.BTNImprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.BTNImprimir.IconColor = System.Drawing.Color.Gainsboro;
            this.BTNImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTNImprimir.IconSize = 36;
            this.BTNImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNImprimir.Location = new System.Drawing.Point(0, 141);
            this.BTNImprimir.Name = "BTNImprimir";
            this.BTNImprimir.Size = new System.Drawing.Size(283, 47);
            this.BTNImprimir.TabIndex = 27;
            this.BTNImprimir.Text = "Imprimir";
            this.BTNImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNImprimir.UseVisualStyleBackColor = false;
            this.BTNImprimir.Click += new System.EventHandler(this.BTNImprimir_Click);
            // 
            // BTNPNG
            // 
            this.BTNPNG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BTNPNG.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNPNG.FlatAppearance.BorderSize = 0;
            this.BTNPNG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNPNG.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPNG.ForeColor = System.Drawing.Color.Gainsboro;
            this.BTNPNG.IconChar = FontAwesome.Sharp.IconChar.FileImage;
            this.BTNPNG.IconColor = System.Drawing.Color.Gainsboro;
            this.BTNPNG.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTNPNG.IconSize = 36;
            this.BTNPNG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNPNG.Location = new System.Drawing.Point(0, 94);
            this.BTNPNG.Name = "BTNPNG";
            this.BTNPNG.Size = new System.Drawing.Size(283, 47);
            this.BTNPNG.TabIndex = 26;
            this.BTNPNG.Text = "PNG";
            this.BTNPNG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNPNG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNPNG.UseVisualStyleBackColor = false;
            this.BTNPNG.Click += new System.EventHandler(this.BTNPNG_Click);
            // 
            // BTNSVG
            // 
            this.BTNSVG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BTNSVG.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNSVG.FlatAppearance.BorderSize = 0;
            this.BTNSVG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSVG.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSVG.ForeColor = System.Drawing.Color.Gainsboro;
            this.BTNSVG.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            this.BTNSVG.IconColor = System.Drawing.Color.Gainsboro;
            this.BTNSVG.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTNSVG.IconSize = 36;
            this.BTNSVG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNSVG.Location = new System.Drawing.Point(0, 47);
            this.BTNSVG.Name = "BTNSVG";
            this.BTNSVG.Size = new System.Drawing.Size(283, 47);
            this.BTNSVG.TabIndex = 25;
            this.BTNSVG.Text = "SVG";
            this.BTNSVG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNSVG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNSVG.UseVisualStyleBackColor = false;
            this.BTNSVG.Click += new System.EventHandler(this.BTNSVG_Click);
            // 
            // BTNPDF
            // 
            this.BTNPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BTNPDF.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTNPDF.FlatAppearance.BorderSize = 0;
            this.BTNPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNPDF.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPDF.ForeColor = System.Drawing.Color.Gainsboro;
            this.BTNPDF.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.BTNPDF.IconColor = System.Drawing.Color.Gainsboro;
            this.BTNPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTNPDF.IconSize = 36;
            this.BTNPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNPDF.Location = new System.Drawing.Point(0, 0);
            this.BTNPDF.Name = "BTNPDF";
            this.BTNPDF.Size = new System.Drawing.Size(283, 47);
            this.BTNPDF.TabIndex = 24;
            this.BTNPDF.Text = "PDF";
            this.BTNPDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNPDF.UseVisualStyleBackColor = false;
            this.BTNPDF.Click += new System.EventHandler(this.BTNPDF_Click);
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnConvertir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConvertir.FlatAppearance.BorderSize = 0;
            this.btnConvertir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertir.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConvertir.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.btnConvertir.IconColor = System.Drawing.Color.Gainsboro;
            this.btnConvertir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConvertir.IconSize = 36;
            this.btnConvertir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvertir.Location = new System.Drawing.Point(0, 349);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(283, 61);
            this.btnConvertir.TabIndex = 23;
            this.btnConvertir.Text = "Convertir ";
            this.btnConvertir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvertir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // SubmenuEditar
            // 
            this.SubmenuEditar.BackColor = System.Drawing.Color.White;
            this.SubmenuEditar.Controls.Add(this.BtnDeshacer);
            this.SubmenuEditar.Controls.Add(this.btnRehacer);
            this.SubmenuEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubmenuEditar.Location = new System.Drawing.Point(0, 256);
            this.SubmenuEditar.Name = "SubmenuEditar";
            this.SubmenuEditar.Size = new System.Drawing.Size(283, 93);
            this.SubmenuEditar.TabIndex = 22;
            // 
            // BtnDeshacer
            // 
            this.BtnDeshacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnDeshacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDeshacer.FlatAppearance.BorderSize = 0;
            this.BtnDeshacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeshacer.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeshacer.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnDeshacer.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.BtnDeshacer.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnDeshacer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDeshacer.IconSize = 36;
            this.BtnDeshacer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDeshacer.Location = new System.Drawing.Point(0, 0);
            this.BtnDeshacer.Name = "BtnDeshacer";
            this.BtnDeshacer.Size = new System.Drawing.Size(283, 47);
            this.BtnDeshacer.TabIndex = 23;
            this.BtnDeshacer.Text = "Deshacer";
            this.BtnDeshacer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDeshacer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDeshacer.UseVisualStyleBackColor = false;
            this.BtnDeshacer.Click += new System.EventHandler(this.BtnDeshacer_Click);
            // 
            // btnRehacer
            // 
            this.btnRehacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnRehacer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRehacer.FlatAppearance.BorderSize = 0;
            this.btnRehacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRehacer.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRehacer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRehacer.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.btnRehacer.IconColor = System.Drawing.Color.Gainsboro;
            this.btnRehacer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRehacer.IconSize = 36;
            this.btnRehacer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRehacer.Location = new System.Drawing.Point(0, 46);
            this.btnRehacer.Name = "btnRehacer";
            this.btnRehacer.Size = new System.Drawing.Size(283, 47);
            this.btnRehacer.TabIndex = 24;
            this.btnRehacer.Text = "Rehacer";
            this.btnRehacer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRehacer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRehacer.UseVisualStyleBackColor = false;
            this.btnRehacer.Click += new System.EventHandler(this.btnRehacer_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 36;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(0, 195);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(283, 61);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // SubmenuArchivo
            // 
            this.SubmenuArchivo.Controls.Add(this.btnGuardar);
            this.SubmenuArchivo.Controls.Add(this.btnAbrir);
            this.SubmenuArchivo.Controls.Add(this.btnnuevo);
            this.SubmenuArchivo.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubmenuArchivo.Location = new System.Drawing.Point(0, 61);
            this.SubmenuArchivo.Name = "SubmenuArchivo";
            this.SubmenuArchivo.Size = new System.Drawing.Size(283, 134);
            this.SubmenuArchivo.TabIndex = 20;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 36;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(0, 87);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(283, 44);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAbrir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbrir.FlatAppearance.BorderSize = 0;
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAbrir.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.btnAbrir.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAbrir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAbrir.IconSize = 36;
            this.btnAbrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrir.Location = new System.Drawing.Point(0, 44);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(283, 43);
            this.btnAbrir.TabIndex = 23;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnnuevo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnnuevo.FlatAppearance.BorderSize = 0;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnnuevo.IconChar = FontAwesome.Sharp.IconChar.ProjectDiagram;
            this.btnnuevo.IconColor = System.Drawing.Color.Gainsboro;
            this.btnnuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnnuevo.IconSize = 36;
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnuevo.Location = new System.Drawing.Point(0, 0);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(283, 44);
            this.btnnuevo.TabIndex = 22;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // hidden
            // 
            this.hidden.BackBrush = new MindFusion.Drawing.SolidBrush("#FFFFFFFF");
            this.hidden.LinkBaseShapeSize = 12F;
            this.hidden.LinkHeadShapeSize = 12F;
            this.hidden.LinkIntermediateShapeSize = 12F;
            this.hidden.MeasureUnit = MindFusion.Diagramming.MeasureUnit.Pixel;
            this.hidden.RoutingOptions.GridSize = 16F;
            this.hidden.RoutingOptions.NodeVicinitySize = 48F;
            this.hidden.SelectAfterCreate = false;
            this.hidden.ShapeNodeStyle.Brush = new MindFusion.Drawing.SolidBrush("#FF00BFFF");
            this.hidden.TouchThreshold = 0F;
            // 
            // ContextMenu
            // 
            this.ContextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this._menuItemDelete});
            // 
            // _menuItemDelete
            // 
            this._menuItemDelete.Index = 0;
            this._menuItemDelete.Text = "Delete";
            this._menuItemDelete.Click += new System.EventHandler(this.Delete);
            // 
            // Formprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 939);
            this.Name = "Formprincipal";
            this.panelsidebar.ResumeLayout(false);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            this.panelfill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ActualSeleccionbox)).EndInit();
            this.panelInvocarForms.ResumeLayout(false);
            this.panelProperties.ResumeLayout(false);
            this.panelfig.ResumeLayout(false);
            this.TabCTR.ResumeLayout(false);
            this.Figuras.ResumeLayout(false);
            this.Conectores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLogo.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.SubmenuInformacion.ResumeLayout(false);
            this.SubmenuConvertir.ResumeLayout(false);
            this.SubmenuEditar.ResumeLayout(false);
            this.SubmenuArchivo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton BTNArchivo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox ActualSeleccionbox;
        private FontAwesome.Sharp.IconButton btnexit;
        private System.Windows.Forms.Panel panelInvocarForms;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel SubmenuArchivo;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnAbrir;
        private FontAwesome.Sharp.IconButton btnnuevo;
        private System.Windows.Forms.Panel SubmenuEditar;
        private FontAwesome.Sharp.IconButton BtnDeshacer;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnRehacer;
        private System.Windows.Forms.Panel SubmenuConvertir;
        private FontAwesome.Sharp.IconButton btnConvertir;
        private FontAwesome.Sharp.IconButton BTNPNG;
        private FontAwesome.Sharp.IconButton BTNSVG;
        private FontAwesome.Sharp.IconButton BTNPDF;
        private FontAwesome.Sharp.IconButton BTNINFO;
        private FontAwesome.Sharp.IconButton BTNImprimir;
        private System.Windows.Forms.Panel SubmenuInformacion;
        private FontAwesome.Sharp.IconButton BTNAcerca;
        public MindFusion.Diagramming.WinForms.DiagramView DiagramaVer;
        private MindFusion.Diagramming.Diagram Diagrama;
        private System.Windows.Forms.Panel panelfig;
        public System.Windows.Forms.TabControl TabCTR;
        public System.Windows.Forms.TabPage Figuras;
        public System.Windows.Forms.ListBox lstNODOList;
        public System.Windows.Forms.TabPage Conectores;
        public System.Windows.Forms.ListBox lstFlechasConectors;
        public System.Windows.Forms.ComboBox CBMTipoFlechaConectors;
        private System.Windows.Forms.Panel panelProperties;
        public System.Windows.Forms.PropertyGrid GridPropiedades;
        public System.Windows.Forms.OpenFileDialog OpenDialog;
        public System.Windows.Forms.SaveFileDialog SaveDialog;
        public MindFusion.Diagramming.Diagram hidden;
        public System.Windows.Forms.ContextMenu ContextMenu;
        public System.Windows.Forms.MenuItem _menuItemDelete;
    }
}