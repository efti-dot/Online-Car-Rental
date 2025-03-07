
<%@ Page Title="" Language="C#" MasterPageFile="~/View/Customer/CustomerMaster.Master" AutoEventWireup="true" CodeBehind="PendingRentals.aspx.cs" Inherits="OnlineCarRental.View.Customer.PendingRentals" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        body {
            background-color: #f8f9fa; 
            margin: 0;
            padding: 0;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            color: #333333;
        }

        .navbar {
            background-color: #dc3545; 
            padding: 15px;
            border-bottom: 1px solid #f2f2f2; 
        }

        .navbar-brand {
            color: #ffffff; 
            font-size: 24px;
            font-weight: bold;
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
            color: red; 
            margin-bottom: 20px;
        }

        #RentList {
            margin-top: 20px;
        }

        
        #RentList tr:nth-child(even) {
            background-color: #f2f2f2;
        }
    </style>

    

    <div class="container">
        <div class="row">
            <div class="col-md-12 text-center">
                <h2>My Rentals</h2>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <asp:GridView runat="server" ID="RentList" CssClass="table table-hover" OnSelectedIndexChanged="RentList_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="#f2f2f2" ForeColor="#333333" />
                </asp:GridView>
            </div>
            <label id="ErrorMsg" runat="server"></label>
            
        </div>
    </div>
</asp:Content>
