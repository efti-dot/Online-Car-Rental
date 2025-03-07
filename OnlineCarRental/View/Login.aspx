

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OnlineCarRental.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"/>
    
    <style>
        body {
            background-image: url('../../Assets/Img/bgimg3.jpg');
            background-size: cover;
            background-repeat: no-repeat;
            background-attachment: fixed;
            margin: 0;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            color: #f5f5dc;
        }

        .container {
            max-width: 400px;
            margin: 100px auto;
        }

        .login-container {
            background-color: #ffffff;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            color: #333333;
            padding: 20px;
            margin: 20px;
        }

        .form-group {
            margin-bottom: 20px;
        }

        .radio-group label {
            margin-right: 20px;
        }

        #ErrorMsg {
            color: #dc3545;
            font-size: 14px;
            margin-top: 10px;
            display: block;
        }

        h2 {
            font-family: 'Montserrat', sans-serif;
            text-align: center;
            margin-bottom: 20px;
        }

        .text-center {
            text-align: center;
        }

        #LoginBtn {
            background-color: red;
            color: white;
            border: none;
            padding: 10px 20px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 16px;
            border-radius: 5px;
            cursor: pointer;
            transition: background-color 0.3s;
        }

        #LoginBtn:hover {
            background-color: #45a049;
        }
    </style>
    <link rel="stylesheet" href="https://fonts.googleapis.com/css2?family=Montserrat:wght@400;700&display=swap">
</head>
<body>
    <div class="text-center">
        <div class="login-container">
            <h1>Online Car Rental</h1>
        </div>
        
    </div>
    
    <div class="container">
        
        <div class="login-container">
            
            <h2>Login</h2>

            <form id="form1" runat="server">
                <div class="form-group">
                    <label for="EmailTb" class="form-label">Email</label>
                    <span style="margin-left: 27px;"></span>
                    <input type="text" class="form-control" id="EmailTb" aria-describedby="emailHelp" runat="server" />
                </div>

                <div class="form-group">
                    <label for="PasswordTb" class="form-label">Password</label>
                    <input type="password" class="form-control" id="PasswordTb" runat="server" />
                </div>
                <div class="form-group radio-group">
                    <div class="form-check form-check-inline">
                        <input type="radio" class="form-check-input" id="AdminRadio" name="role" runat="server" />
                        <label class="form-check-label" for="AdminRadio">Admin</label>
                    </div>
                    <div class="form-check form-check-inline">
                        <input type="radio" class="form-check-input" id="CustomerRadio" name="role" runat="server" />
                        <label class="form-check-label" for="CustomerRadio">Customer</label>
                    </div>
                </div>
                <div class="text-center">
                    <asp:Button type="submit" ID="LoginBtn" class="btn btn-danger btn-block" Text="Login" runat="server" OnClick="LoginBtn_Click" />
                </div>
                <p class="mt-3"></p>
                <div class="text-center">
                    <a href="https://localhost:44362/View/Registration.aspx" class="btn btn-outline-danger btn-block" id="RegBtn" runat="server" onclick="RegBtn_Click">Register Now!</a>
                </div>
                <div class="text-center">
                    <a href="https://localhost:44362/View/ForgotPassword.aspx" class="btn btn-link btn-block" id="ForgotBtn" runat="server" onclick="ForBtn_Click">Forgot Password?</a>
                    <label id="ErrorMsg" runat="server"></label>
                </div>
            </form>

        </div>
    </div>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-eUQ3eTl4ZRq2zqC3H6dUAC6tCJ1Wg7AjbfIJJlTLw4yIaIYXRSzr0Rdm/N5CrFj" crossorigin="anonymous"></script>
</body>
</html>
