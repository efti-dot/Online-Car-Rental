<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResetPassword.aspx.cs" Inherits="OnlineCarRental.View.ResetPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reset Password</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <style>
        body {
            background-image: url('../../Assets/Img/bgimg3.jpg');
            background-size: cover;
            background-repeat: no-repeat;
            background-attachment: fixed;
            margin: 0;
        }

        .container {
            max-width: 400px;
            margin: auto;
            margin-top: 50px;
            padding: 20px;
            background-color: #ffffff;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        .form-group {
            margin-bottom: 20px;
        }

        .btn-reset {
            background-color: #dc3545;
            color: #fff;
        }

        .btn-reset:hover {
            background-color: #c82333;
        }

        #ErrorMsg {
            color: #dc3545;
            font-weight: bold;
            margin-top: 10px;
            display: block;
        }
    </style>
</head>
<body>
    <div class="container">
        <h2 class="text-center mb-4">Reset Password</h2>
        <form id="form1" runat="server">
            <div class="form-group">
                <label for="inputPassword" class="form-label">Your ID</label>
                <input type="exampleInputEmail1" class="form-control" id="UId" runat="server" />
            </div>
            <div class="form-group">
                <label for="inputPassword" class="form-label">New Password</label>
                <input type="password" class="form-control" id="inputPassword" runat="server" />
            </div>
            <div class="form-group">
                <label for="inputRepeatPassword" class="form-label">Confirm Password</label>
                <input type="password" class="form-control" id="inputRepeatPassword" runat="server" />
            </div>

            <asp:Button type="submit" ID="ResetBtn" class="btn btn-danger btn-block" Text="Reset" runat="server" OnClick="ResetBtn_Click" />
            <asp:Button type="submit" ID="LoginBtn" class="btn btn-danger btn-block" Text="Login Now!" runat="server" OnClick="LoginBtn_Click" />

            <label id="ErrorMsg" runat="server"></label>
        </form>
    </div>
</body>
</html>