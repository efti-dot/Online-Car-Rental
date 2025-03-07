
<%@ Page Title="" Language="C#" MasterPageFile="~/View/Customer/CustomerMaster.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="OnlineCarRental.View.Customer.Payment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    


    <!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>bKash Payment</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f5f5f5;
        }

        .container {
            max-width: 400px;
            margin: 50px auto;
            border-radius: 5px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            overflow: hidden;
        }

        .img1 {
            background-color: white;
            padding: 10px;
        }

        .img2 {
            background-color: #e31d60;
            color: white;
            padding: 20px;
            box-sizing: border-box;
        }

        h2 {
            text-align: center;
            color: #fff;
            margin-bottom: 20px;
        }

        .form-group {
            margin-bottom: 20px;
        }

        .form-group label {
            display: block;
            margin-bottom: 5px;
            color: white;
        }

        .form-group input[type="text"],
        .form-group input[type="number"],
        .form-group input[type="password"] {
            width: 100%;
            padding: 10px;
            border: 1px solid #ddd;
            border-radius: 5px;
            box-sizing: border-box;
            margin-top: 5px;
        }

        .form-group input[type="submit"] {
            width: 48%;
            background-color: #ddd;
            color: #e31d60;
            padding: 10px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            font-size: 16px;
            display: inline-block;
        }

        .form-group input[type="submit"]:hover {
            background-color: #f0f0f0;
        }

        .cancel {
            margin-top: 10px;
        }

        .small-text {
            font-size: 12px;
            text-align: center;
            color: white;
        }

        .red-text {
            color: deeppink;
        }

        .center {
            text-align: center;
        }

        img {
            padding: 10px 20px;
            border-radius: 5px;
            margin-bottom: 10px;
            vertical-align: middle;
        }
    </style>
</head>
<body>
    <div class="container">
        <div class="img1">
            <img src="../../Assets/Img/bkashpaymentlogo500x200.png" alt="Your Image" width="90%">
        </div>
        <div class="img2">
         
            <form action="#" method="post">
                <div class="form-group">
                    <label for="amount">Amount</label>
                    <asp:label type="number" id="amountTK" name="amount" placeholder="Enter amount" runat="server"> </asp:Label>
                </div>

                <div class="form-group">
                    <label for="amount">RetID</label>
                    <asp:Label type="number" ID="CustName" name="amount" placeholder="Enter amount" runat="server"> </asp:Label>
                </div>

                <div class="form-group">
                    <label for="phone">Your bKash Account number</label>
                    <input type="text" id="phone" name="phone" placeholder="e.g 01XXXXXXXXX" runat="server">
                </div>

                <div class="form-group">
                    <label for="password">Enter your Password</label>
                    <input type="password" id="password" name="password" placeholder="XXXXXXXXX" runat="server">
                </div>

                <p class="small-text">By clicking on Confirm, you are agreeing to the <a href="https://www.bkash.com/en/page/terms-and-conditions#:~:text=bKash%20provides%20a%20secure%20transaction,entirely%20at%20your%20own%20risk." target="_blank">terms & conditions</a></p>
                
                <label id="ErrorMsg" runat="server"></label>
                <div class="form-group">
                    <asp:button class="cancel" type="submit" Text="Cancle" value="Cancel" runat="server" OnClick="Unnamed1_Click" /></asp:button> <!-- Assuming this is the cancel button -->
                    <asp:button class="cancel" type="submit" Text="Confirm" value="Cancel" runat="server" OnClick="Unnamed2_Click" /></asp:button>
                </div>
            </form>
        </div>
        <div class="img1">
            <div class="center">
                <p><img src="../../Assets/Img/phone.png" width="5%" height="auto"> <span class="red-text"> 16247 </span></p>
            </div>
        </div>
    </div>
</body>
</html>






</asp:Content>

