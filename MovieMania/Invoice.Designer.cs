namespace MovieMania
{
    partial class Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.pboLogo = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCustDetails = new System.Windows.Forms.Label();
            this.lblRecieptDate = new System.Windows.Forms.Label();
            this.lblRecieptDateTitle = new System.Windows.Forms.Label();
            this.lblMoviesRented = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.pnlMovLineTop = new System.Windows.Forms.Panel();
            this.lblRate0 = new System.Windows.Forms.Label();
            this.lblQty0 = new System.Windows.Forms.Label();
            this.lblMov0 = new System.Windows.Forms.Label();
            this.lblRate1 = new System.Windows.Forms.Label();
            this.lblQty1 = new System.Windows.Forms.Label();
            this.lblMov1 = new System.Windows.Forms.Label();
            this.pnlMovLineBottom = new System.Windows.Forms.Panel();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblPeriod1 = new System.Windows.Forms.Label();
            this.lblPeriod0 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblStaffId = new System.Windows.Forms.Label();
            this.lblStaffIdTitle = new System.Windows.Forms.Label();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.lblInvoiceNoTitle = new System.Windows.Forms.Label();
            this.lblAddr1 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblSubTotalValue = new System.Windows.Forms.Label();
            this.lblVatValue = new System.Windows.Forms.Label();
            this.lblTotalCostValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pboLogo
            // 
            this.pboLogo.BackColor = System.Drawing.Color.White;
            this.pboLogo.Image = ((System.Drawing.Image)(resources.GetObject("pboLogo.Image")));
            this.pboLogo.Location = new System.Drawing.Point(150, 0);
            this.pboLogo.Name = "pboLogo";
            this.pboLogo.Size = new System.Drawing.Size(200, 200);
            this.pboLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboLogo.TabIndex = 0;
            this.pboLogo.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.pnlTop.Location = new System.Drawing.Point(29, 167);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(460, 3);
            this.pnlTop.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lblName.Location = new System.Drawing.Point(27, 245);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(91, 25);
            this.lblName.TabIndex = 49;
            this.lblName.Text = "John Doe";
            // 
            // lblCustDetails
            // 
            this.lblCustDetails.AutoSize = true;
            this.lblCustDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lblCustDetails.Location = new System.Drawing.Point(23, 213);
            this.lblCustDetails.Name = "lblCustDetails";
            this.lblCustDetails.Size = new System.Drawing.Size(159, 25);
            this.lblCustDetails.TabIndex = 48;
            this.lblCustDetails.Text = "Customer Details";
            // 
            // lblRecieptDate
            // 
            this.lblRecieptDate.AutoSize = true;
            this.lblRecieptDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecieptDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lblRecieptDate.Location = new System.Drawing.Point(387, 245);
            this.lblRecieptDate.Name = "lblRecieptDate";
            this.lblRecieptDate.Size = new System.Drawing.Size(106, 25);
            this.lblRecieptDate.TabIndex = 51;
            this.lblRecieptDate.Text = "24/04/2024";
            // 
            // lblRecieptDateTitle
            // 
            this.lblRecieptDateTitle.AutoSize = true;
            this.lblRecieptDateTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecieptDateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lblRecieptDateTitle.Location = new System.Drawing.Point(254, 245);
            this.lblRecieptDateTitle.Name = "lblRecieptDateTitle";
            this.lblRecieptDateTitle.Size = new System.Drawing.Size(126, 25);
            this.lblRecieptDateTitle.TabIndex = 50;
            this.lblRecieptDateTitle.Text = "Reciept Date:";
            // 
            // lblMoviesRented
            // 
            this.lblMoviesRented.AutoSize = true;
            this.lblMoviesRented.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoviesRented.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lblMoviesRented.Location = new System.Drawing.Point(24, 380);
            this.lblMoviesRented.Name = "lblMoviesRented";
            this.lblMoviesRented.Size = new System.Drawing.Size(139, 25);
            this.lblMoviesRented.TabIndex = 52;
            this.lblMoviesRented.Text = "Movies Rented";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lblQuantity.Location = new System.Drawing.Point(270, 380);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(87, 25);
            this.lblQuantity.TabIndex = 53;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lblRate.Location = new System.Drawing.Point(436, 380);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(51, 25);
            this.lblRate.TabIndex = 54;
            this.lblRate.Text = "Rate";
            // 
            // pnlMovLineTop
            // 
            this.pnlMovLineTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.pnlMovLineTop.Location = new System.Drawing.Point(29, 408);
            this.pnlMovLineTop.Name = "pnlMovLineTop";
            this.pnlMovLineTop.Size = new System.Drawing.Size(459, 1);
            this.pnlMovLineTop.TabIndex = 2;
            // 
            // lblRate0
            // 
            this.lblRate0.AutoSize = true;
            this.lblRate0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lblRate0.Location = new System.Drawing.Point(436, 415);
            this.lblRate0.Name = "lblRate0";
            this.lblRate0.Size = new System.Drawing.Size(46, 25);
            this.lblRate0.TabIndex = 57;
            this.lblRate0.Text = "4.00";
            // 
            // lblQty0
            // 
            this.lblQty0.AutoSize = true;
            this.lblQty0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lblQty0.Location = new System.Drawing.Point(303, 415);
            this.lblQty0.Name = "lblQty0";
            this.lblQty0.Size = new System.Drawing.Size(22, 25);
            this.lblQty0.TabIndex = 56;
            this.lblQty0.Text = "1";
            this.lblQty0.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMov0
            // 
            this.lblMov0.AutoSize = true;
            this.lblMov0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMov0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lblMov0.Location = new System.Drawing.Point(24, 415);
            this.lblMov0.Name = "lblMov0";
            this.lblMov0.Size = new System.Drawing.Size(155, 25);
            this.lblMov0.TabIndex = 55;
            this.lblMov0.Text = "Superman (2025)";
            // 
            // lblRate1
            // 
            this.lblRate1.AutoSize = true;
            this.lblRate1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lblRate1.Location = new System.Drawing.Point(437, 444);
            this.lblRate1.Name = "lblRate1";
            this.lblRate1.Size = new System.Drawing.Size(46, 25);
            this.lblRate1.TabIndex = 60;
            this.lblRate1.Text = "7.80";
            // 
            // lblQty1
            // 
            this.lblQty1.AutoSize = true;
            this.lblQty1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lblQty1.Location = new System.Drawing.Point(303, 447);
            this.lblQty1.Name = "lblQty1";
            this.lblQty1.Size = new System.Drawing.Size(22, 25);
            this.lblQty1.TabIndex = 59;
            this.lblQty1.Text = "2";
            this.lblQty1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMov1
            // 
            this.lblMov1.AutoSize = true;
            this.lblMov1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMov1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lblMov1.Location = new System.Drawing.Point(24, 444);
            this.lblMov1.Name = "lblMov1";
            this.lblMov1.Size = new System.Drawing.Size(166, 25);
            this.lblMov1.TabIndex = 58;
            this.lblMov1.Text = "Cinderella\'s Castle";
            // 
            // pnlMovLineBottom
            // 
            this.pnlMovLineBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.pnlMovLineBottom.Location = new System.Drawing.Point(28, 480);
            this.pnlMovLineBottom.Name = "pnlMovLineBottom";
            this.pnlMovLineBottom.Size = new System.Drawing.Size(459, 1);
            this.pnlMovLineBottom.TabIndex = 3;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lblPeriod.Location = new System.Drawing.Point(363, 380);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(66, 25);
            this.lblPeriod.TabIndex = 61;
            this.lblPeriod.Text = "Period";
            // 
            // lblPeriod1
            // 
            this.lblPeriod1.AutoSize = true;
            this.lblPeriod1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lblPeriod1.Location = new System.Drawing.Point(383, 447);
            this.lblPeriod1.Name = "lblPeriod1";
            this.lblPeriod1.Size = new System.Drawing.Size(22, 25);
            this.lblPeriod1.TabIndex = 63;
            this.lblPeriod1.Text = "7";
            this.lblPeriod1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPeriod0
            // 
            this.lblPeriod0.AutoSize = true;
            this.lblPeriod0.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lblPeriod0.Location = new System.Drawing.Point(383, 415);
            this.lblPeriod0.Name = "lblPeriod0";
            this.lblPeriod0.Size = new System.Drawing.Size(22, 25);
            this.lblPeriod0.TabIndex = 62;
            this.lblPeriod0.Text = "3";
            this.lblPeriod0.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lblSubTotal.Location = new System.Drawing.Point(333, 484);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(90, 25);
            this.lblSubTotal.TabIndex = 64;
            this.lblSubTotal.Text = "Sub Total";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lblVat.Location = new System.Drawing.Point(378, 509);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(45, 25);
            this.lblVat.TabIndex = 65;
            this.lblVat.Text = "VAT";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lblTotalCost.Location = new System.Drawing.Point(327, 534);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(96, 25);
            this.lblTotalCost.TabIndex = 66;
            this.lblTotalCost.Text = "Total Cost";
            // 
            // lblStaffId
            // 
            this.lblStaffId.AutoSize = true;
            this.lblStaffId.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lblStaffId.Location = new System.Drawing.Point(386, 277);
            this.lblStaffId.Name = "lblStaffId";
            this.lblStaffId.Size = new System.Drawing.Size(72, 25);
            this.lblStaffId.TabIndex = 70;
            this.lblStaffId.Text = "110125";
            // 
            // lblStaffIdTitle
            // 
            this.lblStaffIdTitle.AutoSize = true;
            this.lblStaffIdTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffIdTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lblStaffIdTitle.Location = new System.Drawing.Point(298, 277);
            this.lblStaffIdTitle.Name = "lblStaffIdTitle";
            this.lblStaffIdTitle.Size = new System.Drawing.Size(82, 25);
            this.lblStaffIdTitle.TabIndex = 69;
            this.lblStaffIdTitle.Text = "Staff ID:";
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lblInvoiceNo.Location = new System.Drawing.Point(387, 213);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(82, 25);
            this.lblInvoiceNo.TabIndex = 72;
            this.lblInvoiceNo.Text = "1234568";
            // 
            // lblInvoiceNoTitle
            // 
            this.lblInvoiceNoTitle.AutoSize = true;
            this.lblInvoiceNoTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lblInvoiceNoTitle.Location = new System.Drawing.Point(270, 213);
            this.lblInvoiceNoTitle.Name = "lblInvoiceNoTitle";
            this.lblInvoiceNoTitle.Size = new System.Drawing.Size(110, 25);
            this.lblInvoiceNoTitle.TabIndex = 71;
            this.lblInvoiceNoTitle.Text = "Invoice No:";
            // 
            // lblAddr1
            // 
            this.lblAddr1.AutoSize = true;
            this.lblAddr1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddr1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lblAddr1.Location = new System.Drawing.Point(27, 272);
            this.lblAddr1.Name = "lblAddr1";
            this.lblAddr1.Size = new System.Drawing.Size(141, 25);
            this.lblAddr1.TabIndex = 73;
            this.lblAddr1.Text = "Orkney College";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lblCity.Location = new System.Drawing.Point(27, 302);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(78, 25);
            this.lblCity.TabIndex = 74;
            this.lblCity.Text = "Kirkwall";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lblPostcode.Location = new System.Drawing.Point(27, 332);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(96, 25);
            this.lblPostcode.TabIndex = 75;
            this.lblPostcode.Text = "KW15 1LX";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(388, 589);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(105, 36);
            this.btnPrint.TabIndex = 76;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // lblSubTotalValue
            // 
            this.lblSubTotalValue.AutoSize = true;
            this.lblSubTotalValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lblSubTotalValue.Location = new System.Drawing.Point(427, 484);
            this.lblSubTotalValue.Name = "lblSubTotalValue";
            this.lblSubTotalValue.Size = new System.Drawing.Size(66, 25);
            this.lblSubTotalValue.TabIndex = 77;
            this.lblSubTotalValue.Text = "£11.80";
            // 
            // lblVatValue
            // 
            this.lblVatValue.AutoSize = true;
            this.lblVatValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVatValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lblVatValue.Location = new System.Drawing.Point(432, 509);
            this.lblVatValue.Name = "lblVatValue";
            this.lblVatValue.Size = new System.Drawing.Size(56, 25);
            this.lblVatValue.TabIndex = 78;
            this.lblVatValue.Text = "£2.36";
            // 
            // lblTotalCostValue
            // 
            this.lblTotalCostValue.AutoSize = true;
            this.lblTotalCostValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCostValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.lblTotalCostValue.Location = new System.Drawing.Point(427, 534);
            this.lblTotalCostValue.Name = "lblTotalCostValue";
            this.lblTotalCostValue.Size = new System.Drawing.Size(66, 25);
            this.lblTotalCostValue.TabIndex = 79;
            this.lblTotalCostValue.Text = "£14.16";
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(515, 641);
            this.Controls.Add(this.lblTotalCostValue);
            this.Controls.Add(this.lblVatValue);
            this.Controls.Add(this.lblSubTotalValue);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddr1);
            this.Controls.Add(this.lblInvoiceNo);
            this.Controls.Add(this.lblInvoiceNoTitle);
            this.Controls.Add(this.lblStaffId);
            this.Controls.Add(this.lblStaffIdTitle);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblVat);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblPeriod1);
            this.Controls.Add(this.lblPeriod0);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.pnlMovLineBottom);
            this.Controls.Add(this.lblRate1);
            this.Controls.Add(this.lblQty1);
            this.Controls.Add(this.lblMov1);
            this.Controls.Add(this.lblRate0);
            this.Controls.Add(this.lblQty0);
            this.Controls.Add(this.lblMov0);
            this.Controls.Add(this.pnlMovLineTop);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblMoviesRented);
            this.Controls.Add(this.lblRecieptDate);
            this.Controls.Add(this.lblRecieptDateTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCustDetails);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pboLogo);
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboLogo;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCustDetails;
        private System.Windows.Forms.Label lblRecieptDate;
        private System.Windows.Forms.Label lblRecieptDateTitle;
        private System.Windows.Forms.Label lblMoviesRented;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Panel pnlMovLineTop;
        private System.Windows.Forms.Label lblRate0;
        private System.Windows.Forms.Label lblQty0;
        private System.Windows.Forms.Label lblMov0;
        private System.Windows.Forms.Label lblRate1;
        private System.Windows.Forms.Label lblQty1;
        private System.Windows.Forms.Label lblMov1;
        private System.Windows.Forms.Panel pnlMovLineBottom;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblPeriod1;
        private System.Windows.Forms.Label lblPeriod0;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblStaffId;
        private System.Windows.Forms.Label lblStaffIdTitle;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Label lblInvoiceNoTitle;
        private System.Windows.Forms.Label lblAddr1;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblSubTotalValue;
        private System.Windows.Forms.Label lblVatValue;
        private System.Windows.Forms.Label lblTotalCostValue;
    }
}