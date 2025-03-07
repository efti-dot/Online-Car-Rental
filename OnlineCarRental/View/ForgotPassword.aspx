<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="OnlineCarRental.View.ForgotPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Forgot Password</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous">
    <style>
        body {
            background-image: url('../../Assets/Img/bgimg3.jpg');
            background-size: cover;
            background-repeat: no-repeat;
            background-attachment: fixed;
            margin: 0;
        }

        .forgot-password-container {
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

        .btn-forgot-password {
            width: 20%;
        }
    </style>
</head>
<body>


    <div class="forgot-password-container">
        <h2 class="text-center mb-4">Forgot Password</h2>
        <form id="form1" runat="server">
            <div class="form-group">
                <asp:TextBox ID="exampleInputEmail" CssClass="form-control" placeholder="Email Address" runat="server"></asp:TextBox>
            </div>
            <asp:Button type="submit" ID="EditBtn" CssClass="btn btn-danger btn-forgot-password" Text="Send" runat="server" OnClick="EditBtn_Click" />
            <a href="https://localhost:44362/View/Login.aspx" class="btn btn-link btn-block" id="loginBtn" runat="server" onclick="ForBtn_Click">Back to Login</a>
        </form>
    </div>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-eUQ3eTl4ZRq2zqC3H6dUAC6tCJ1Wg7AjbfIJJlTLw4yIaIYXRSzr0Rdm/N5CrFj" crossorigin="anonymous"></script>
</body>
</html>