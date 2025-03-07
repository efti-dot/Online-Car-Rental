<%@ Page Title="" Language="C#" MasterPageFile="~/View/Customer/CustomerMaster.Master" AutoEventWireup="true" CodeBehind="Cars.aspx.cs" Inherits="OnlineCarRental.View.Customer.Cars" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        body {
            background-color: floralwhite; 
            margin: 0;
            padding: 0;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            color: #333333;
        }

        .navbar {
            background-color: #dc3545; 
            padding: 15px;
            border-bottom: 1px solid #f2f2f2;
            display: flex;
            align-items: center; 
        }

        .navbar-brand {
            color: white; 
            font-size: 24px;
            font-weight: bold;
            margin-left: 10px; 
        }

        .brand-image {
            width: 550px; 
            height: 500px; 
            margin-right: 10px; 
        }

        .container {
            width: 80%;
            margin: auto;
            padding: 0; 
            background-color: transparent; 
            border-radius: 0; 
            box-shadow: none; 
            margin-top: 50px;
        }

        h2 {
            font-weight: bold;
            text-align: center;
            color: #dc3545;
            margin-bottom: 20px;
        }

        .form-group {
            margin-bottom: 15px;
            margin-right:100px;
            
            
        }

        .btn-danger {
            background-color: #dc3545;
            border-color: #dc3545;
        }

        .btn-danger:hover {
            background-color: #c82333;
            border-color: #bd2130;
        }
    </style>

    <div class="container-fluid">
        <div class="row mt-5">
            <div class="col-md-12 text-center">
                <label id="CustName" runat="server">Welcome, User Name!</label>
            </div>
        </div>

        <div class="row mt-4">
            <div class="col-md-6">
                <img src="../../Assets/Img/OnlineTaxi.jpg" class="brand-image" alt="Car Image" />
            </div>
            <div class="col-md-6">
                <div class="row">
                    <div class="col-md-12 text-center">
                        <h2>Available Cars</h2>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <asp:GridView runat="server" ID="GridView1" CssClass="table table-danger" AutoGenerateSelectButton="True" PageSize="6" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                            <AlternatingRowStyle BackColor="#FFCC00" />
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>

        <div class="row mt-3">
            <div class="col-md-4 offset-md-8">
                <div class="form-group">
                    <input type="date" class="form-control" id="ReturnDate" runat="server" />
                </div>
            </div>
        </div>

        <div class="row mt-3">
            <div class="col-md-4 offset-md-8">
                <div class="form-group d-grid">
                    <label id="InfoMsg" runat="server" class="Text-danger"></label>
                    <asp:Button type="submit" ID="BookBtn" CssClass="btn btn-danger btn-block" Text="Book" runat="server" OnClick="BookBtn_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>