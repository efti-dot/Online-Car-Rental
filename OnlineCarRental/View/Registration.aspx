<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="OnlineCarRental.View.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Page</title>
    <link rel="stylesheet" href="../Assets/Libraries/css/bootstrap.min.css" />
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
            max-width: 800px;
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

        .registration-container {
            margin-top: 20px;
        }

        h2 {
            font-family: 'Montserrat', sans-serif;
            text-align: center;
            margin-bottom: 20px;
            color: black;
            font-weight: bold;
        }

        .form-group {
            margin-bottom: 20px;
        }

        .form-group label {
            font-weight: bold;
            display: block;
        }

        .form-group input {
            width: 100%;
        }

        .form-group.text-center {
            margin-inline: 20px;
            margin-top: 20px;
        }

        .checkbox-group {
            display: flex;
            flex-direction: column;
            margin-bottom: 20px;
        }

        .checkbox-group label {
            font-weight: bold;
            margin-bottom: 5px;
        }

        #ErrorMsg {
            color: #dc3545;
            font-size: 14px;
            margin-top: 10px;
            display: block;
        }

        .btn {
            margin-right: 10px;
            margin-bottom: 10px;
        }
    </style>
</head>
<body>
    <div class="container">
        <div class="login-container">
            <h2 class="text-danger text-center">Register Here</h2>

            <form runat="server">
                <div class="registration-container">
                     <div class="form-group">
     <label for="CustomerNameTb" class="form-label">Customer Name</label>
     <input type="text" class="form-control" id="CustomerNameTb" placeholder="Enter Name" runat="server">
 </div>

 <div class="form-group">
     <label for="CustomerId" class="form-label">Customer ID</label>
     <input type="text" class="form-control" id="CustomerId" placeholder="Enter ID Number" runat="server">
 </div>

 <div class="form-group">
     <label for="LicenceTb" class="form-label">Licence No.</label>
     <input type="text" class="form-control" id="LicenceTb" placeholder="Enter Licence Number" runat="server">
 </div>

 <div class="form-group">
     <label for="AddTb" class="form-label">Customer's Address</label>
     <input type="text" class="form-control" id="AddTb" placeholder="Enter Address" runat="server">
 </div>

 <div class="form-group">
     <label for="EmailTb" class="form-label">Customer's Email</label>
     <input type="text" class="form-control" id="EmailTb" placeholder="Enter a valid Email" runat="server">
 </div>

 <div class="form-group">
     <label for="NIdTb" class="form-label">Customer's NID Number</label>
     <input type="text" class="form-control" id="NIdTb" placeholder="Enter NID No." runat="server">
 </div>

 <div class="form-group">
     <label for="PhoneTb" class="form-label">Customer Phone</label>
     <input type="text" class="form-control" id="PhoneTb" placeholder="Enter Phone Number" runat="server">
 </div>

 <div class="form-group">
     <label for="PassTb" class="form-label">Customer's Password</label>
     <input type="password" class="form-control" id="PassTb" placeholder="Enter Password" runat="server">
 </div>

                    <div class="form-group checkbox-group">
                        <label for="checkBox" class="form-label">Are You Sure?</label>
                        <asp:CheckBox ID="checkBox" runat="server" />
                    </div>

                    <div class="form-group text-center">
                        <asp:Button type="submit" ID="EditBtn" class="btn btn-danger" Text="Register" runat="server" OnClick="RegBtn" />
                        <asp:Button type="submit" ID="ClearBtn" class="btn btn-danger" Text="Clear" runat="server" OnClick="ClearBtn_Click" />
                        <asp:Button type="submit" ID="Button1" class="btn btn-danger" Text="Login Now!" runat="server" OnClick="LoginBtn" />
                    </div>
                </div>

                <label id="ErrorMsg" runat="server"></label>
            </form>
        </div>
    </div>

    <script src="../Assets/Libraries/js/bootstrap.bundle.min.js"></script>
</body>
</html>