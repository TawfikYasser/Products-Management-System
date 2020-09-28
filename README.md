# Products-Management-System

### Introduction

Products management system allows users to manage their products, clients, and orders, also to manage categories and its products, to make the process of selling easier.

---

### Why this project

This project is an application for Software Engineering Principles, Object-Oriented Programming, and Databases.

---

### Tools & Technologies

+ Microsoft Visual Studio Community 2019                     **_(Version 16.7.1)_**
+ Microsoft .Net Framework                                   **_(Version 4.8.04084)_**
+ Microsoft SQL Server Management Studio                     **_(Version 18.6)_**
+ SAP Crystal Reports SP 28                                  **_(Version 13.0.4000.0)_**
+ ERD Plus database modelling                                **_(Version 2.0)_**

---

### System Requirements

Main system functional requirements, starting with that system allow to add products, managing them by edit and delete or print a specific product, or print all products, and also exporting them to excel file, the next feature is that system allow to managing store categories like add new/edit/remove, also managing system customers by add new customers, edit and delete ones, and system main feature is to make new order and save each bill and print it, finally managing system users. As we are talking about all this features above.

---

###### Main Page Interface
![alt text](https://github.com/TawfikYasser/Products-Management-System/blob/master/PMS_Screenshots/Main_page_interface.png?raw=true "Main Page")
###### ER Diagram
![alt text](https://github.com/TawfikYasser/Products-Management-System/blob/master/ER_Diagramv2.png?raw=true "ER Diagram")
###### Relational Schema
![alt text](https://github.com/TawfikYasser/Products-Management-System/blob/master/Relational_Schemav2.png?raw=true "Relational Schema")

---

###### Example of SQL: For adding PRODUCTS table

``` sql
CREATE table PRODUCTS
( ID_PRODUCT varchar(30) PRIMARY KEY NOT NULL,
LABEL_PRODUCT varchar(30),
QTE_IN_SROCK int,
PRICE varchar(50),
IMAGE_PRODUCT image );
```

###### Example of C#: For editing a product

``` c#
        private void button3_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.txtRef.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtDesc.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtQTE.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtPRICE.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.cmbCategories.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.Text = "تعديل المنتج: " + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.btnOK.Text = "تحديث";
            frm.state = "update";
            frm.txtRef.Enabled = false;
            byte[] image = (byte[])prd.GET_IMAGE_PRODUCT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pbox.Image = Image.FromStream(ms);
            frm.ShowDialog();
            this.dataGridView1.DataSource = prd.GET_ALL_PRODUCTS();
            dataGridView1.Refresh();

        }
```

---

> This repo concerned with the connection among Software Engineering (SE) concepts, Object-Oriented Programming (OOP), and Database using SQL (DB).
> Soon the SE Documentation will be added then any `developer` can contribute in it, OOP Conecpts applied in C# Programming Languages, and in the DB part, we used TSQL > > but any one can use SQL or TSQL or even SQL/PL.
### More will be added soon.

###### 2020
