
<%@ Page Title="" Language="C#" MasterPageFile="~/View/Customer/CustomerMaster.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="OnlineCarRental.View.Customer.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
  

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css" />

    <style>
        body {
            background-color: white; 
            margin: 0;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            color: black;
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

        .container {
            display: flex;
            justify-content: space-between;
            align-items: center;
            height: 100vh;
            padding: 20px;
        }

        .introduction {
            flex: 1;
            text-align: left;
        }

        .attractive-style {
            flex: 1;
            text-align: left;
            animation: bounceInRight 2s forwards;
            

        }

        .attractive-style h2 {
            font-size: 70px;
            color: #DC143C;
            margin-bottom: 10px;
            font-weight:bold;
        }

        .attractive-style p {
            font-size: 25px;
            line-height: 1.5;
            margin-bottom: 20px;
            color: #000000;
        }

     

        .contact-form {
            max-width: 400px;
            margin: 0 auto;
            background-color: rgba(255, 255, 255, 0.8); 
            padding: 20px;
            border-radius: 10px;
            margin-top: 50px;
        }

        .social-media {
            position: absolute;
            top: 20px;
            right: 20px;
            text-align: right;
            animation: fadeInUp 2s forwards;
        }

        .social-media a {
            display: inline-block;
            margin-right: 20px;
            color: #f5f5dc;
            font-size: 24px;
            transition: color 0.3s ease-in-out;
        }

        .social-media a:hover {
            color: #f5f5dc;
        }

        .left-image {
            flex: 1;
            text-align: left;
        }

        .left-image img {
            width:510px;
            height:600px;
            border-radius: 10px;
            margin-bottom: 20px;
        }

        @keyframes fadeInLeft {
            from { opacity: 0; transform: translateX(-50px); }
            to { opacity: 1; transform: translateX(0); }
        }

        @keyframes bounceInRight {
            from { opacity: 0; transform: translateX(50px) scale(0.5); }
            to { opacity: 1; transform: translateX(0) scale(1); }
            
        }

        @keyframes fadeInUp {
            from { opacity: 0; transform: translateY(20px); }
            to { opacity: 1; transform: translateY(0); }
        }
    </style>
    <title>Welcome to Online Car Rental</title>

   

    <div class="container">
        <div class="left-image">
            <img src="../../Assets/Img/CarRent.jpg" alt="Left Image">
        </div>

        <div class="introduction">
            
        </div>

        <div class="attractive-style">
            <h2 class="animate__animated animate__bounceInRight">Welcome!</h2>
            <p class="animate__animated animate__bounceInRight">Explore the website and discover a collection of exquisite cars that redefine 
                                                                elegance and performance. Choose your dream car for a memorable journey.</p>
        </div>
    </div>

    

    <div class="social-media">
        <a href="#" target="_blank" class="animate__animated animate__fadeInUp"><i class="fab fa-facebook"></i></a>
        <a href="#" target="_blank" class="animate__animated animate__fadeInUp"><i class="fab fa-twitter"></i></a>
        <a href="#" target="_blank" class="animate__animated animate__fadeInUp"><i class="fab fa-instagram"></i></a>
    </div>
</asp:Content>
