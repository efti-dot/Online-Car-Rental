<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainHome.aspx.cs" Inherits="OnlineCarRental.View.WebForm1" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Your Car Rental</title>
    <style>


        body {
            font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif
            margin: 0;
            padding: 0;
            box-sizing: border-box;
            background-color: floralwhite;
            color: black;
        }

        header {
            background-color: crimson;
            color: white;
            padding: 10px;
            text-align: center;
        }

        nav {
            display: flex;
            justify-content: space-between;
            background-color: #444;
            padding: 10px;
            color: crimson;
        }

        nav a {
            color: white;
            text-decoration: none;
            padding: 10px;
            margin: 0 10px;
            transition: color 0.3s;
            color: white;
            font-weight: bold;
        }

        nav a:hover {
            color: crimson;
        }

        section {
            padding: 20px;
        }

        #home-intro {
            text-align: center;
            position: relative;
        }

        .intro-image-container {
            position: relative;
            display: flex;
        }

        .intro-image-container img {
            width: 100%;
            height: 100%;
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
        }

        .image-overlay {
            position: absolute;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            background: rgba(0, 0, 0, 0.5);
            border-radius: 8px;
            display: flex;
            align-items: center;
            justify-content: space-evenly;
        }

        .slideshow-container {
            position: relative;
            margin: auto;
            overflow: hidden;
        }

        .mySlides {
            display: none;
            width: 100%;
            height: 700px;
        }

        .intro-text {
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
            text-align: center;
            color: #fff;
            z-index: 2;
        }

        .intro-text h2 {
            font-weight: bold;
            font-size: 40px;
            margin-bottom: 10px;
        }

        .intro-text p {
            font-size: 18px;
            line-height: 1.5;
        }

        @keyframes fadeInText {
            from {
                opacity: 0;
            }
            to {
                opacity: 1;
            }
        }
        #about {
        background-color: #f9f9f9;
        padding: 40px;
        border-radius: 8px;
        box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
        margin-top: 20px;
    }

    .about-container {
        display: flex;
        justify-content: space-between;
        align-items: center;
    }

    .about-content {
        flex: 1;
        margin-left: 20px;
    }

    .about-content h2 {
         font-weight:600;
         color:crimson;
         font-size: 40px;
         margin-bottom: 5px;
      
    }

    .about-content p {
        color: black;
        font-size: 22px;
        line-height: 1.5;
       
    }

    .about-container img {
        width: 600px;
        height: 500px;
        
        border-radius: 8px;
        box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
    }
       
        #faqs {
            background-color: crimson;
            padding: 30px;
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            margin-top: 20px;
        }

        #faqs h2 {
            color: white;
            font-size: 40px;
            margin-bottom: 20px;
            text-align:center;

        }

        .faq {
            margin-bottom: 20px;
        }
        .faq-left{
             display: flex;
            flex-direction:column;
            align-items:start;
            

        }
        .faq-right img{
             width: 300px;

        }
        

        .faq h3 {
            color: white;
            font-size: 18px;
            margin-bottom: 10px;
        }

        .faq p {
            font-size: 16px;
            color:aliceblue;
        }

        #contact {
            background-color: #fff;
            padding: 30px;
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            margin-top: 20px;
        }

        .contact-container{
            height:100vh;
            display:flex;
            align-items:center;
            justify-content:space-evenly;
        }
        .contact-left{
            display: flex;
            flex-direction:column;
            align-items:start;
            gap: 20px;
        }
        .contact-left-title h2{
            font-weight:600;
            color:crimson;
            font-size: 40px;
            margin-bottom: 5px;
        }
        .contact-left-title hr{
            border:none;
            width:120px;
            height:5px;
            background-color:blanchedalmond;
            border-radius:10px;
            margin-bottom:20px;
        }
        .contact-inputs{
            width:400px;
            height:50px;
            border:solid;
            outline:none;
            padding-left:25px;
            font-weight:500;
            color:black;
            border-radius:50px;
        }
        .contact-left textarea{
            height:140px;
            padding-top:15px;
            border-radius:20px;
        }
        .contact-inputs:focus{
            border:2px solid #ff994f;

        }
        .contact-left button{
            display:flex;
            align-items:center;
            padding: 15px 30px;
            font-size: 16px;
            color:white;
            gap:10px;
            border:none;
            border-radius:50px;
            background:linear-gradient(270deg,black,red);
            cursor:pointer;

        }
        .contact-right img{
            width: 300px;
        }
    </style>
</head>

<body>

    <header>
        <h1>Online Car Rental</h1>
    </header>

    <nav>
        <div>
            <a href="#home">Home</a>
            <a href="#about">About Us</a>
            <a href="#faqs">FAQs</a>
            <a href="#contact">Contact Us</a>
        </div>
        <div>
            <a href="https://localhost:44362/View/Login.aspx" class="btn btn-outline-danger btn-block" id="A1" runat="server" onclick="LoginBtn_Click">Login</a>
        </div>
    </nav>

    <section id="home-intro" class="slideshow-container">
        <div class="mySlides">
            <img src="../Assets/Img/backimage1.jpg" alt="" />
            <div class="image-overlay">
                <div class="intro-text">
                    <h2>Welcome to Online Car Rental</h2>
                    <p>Explore the world with comfort and style. Rent a car that suits your journey.</p>
                </div>
            </div>
        </div>

        <div class="mySlides">
            <img src="../Assets/Img/login.jpg" alt="" />
            <div class="image-overlay">
                <div class="intro-text">
                    <h2>Discover New Horizons</h2>
                    <p>Experience the freedom of the open road. Your adventure begins with Your Car Rental.</p>
                </div>
            </div>
        </div>

        <div style="text-align: center; margin-top: 20px;">
            <span class="dot"></span>
            <span class="dot"></span>
        </div>
    </section>
     <section id="about">
    <div class="about-container">
        <img src="../Assets/Img/CarRental3.jpg" alt="About Us Image"/>
        <div class="about-content">
            <h2>About Us</h2>
            <p>At Online Car Rental, we understand that every journey is unique, and so are your requirements. Whether you're embarking on a business trip, planning a family vacation, or simply in need of a reliable vehicle for daily commuting, we have a diverse fleet of well-maintained cars to cater to your every need.
Our commitment to excellence extends beyond the vehicles we offer. We are dedicated to ensuring a seamless and enjoyable experience for our customers. From the moment you land on our user-friendly website to the time you return the keys, our goal is to make your car rental experience effortless and stress-free.
What sets us apart is our relentless pursuit of customer satisfaction. Our team of experienced professionals is always ready to assist you in finding the perfect vehicle that aligns with your preferences and budget.</p>
         
        </div>
    </div>
</section>

    <section id="faqs">
        <div class="faq-left-title">
            <h2>Frequently Asked Questions</h2>
            <hr />
        </div>

        <div class="faq">
        <h3 onclick="toggleAnswer(1)">Q: How do I rent a car from Your Car Rental?</h3>
        <p id="answer1" style="display: none;">A: Renting a car is easy! Simply browse our available cars, select the one you like, and follow the online booking process.</p>
    </div>

    <div class="faq">
        <h3 onclick="toggleAnswer(2)">Q: What documents do I need to rent a car?</h3>
        <p id="answer2" style="display: none;">A: You will typically need a valid driver's license, a credit card, and proof of insurance. Additional requirements may vary by location.</p>
    </div>

        <div class="faq">
        <h3 onclick="toggleAnswer(3)">Q: Can I modify or cancel my reservation?</h3>
        <p id="answer3" style="display: none;">A: Yes, you can modify or cancel your reservation through our website or by contacting our customer support. Please check our cancellation policy for details.</p>
    </div>

    <div class="faq">
        <h3 onclick="toggleAnswer(4)">Q: Are there age restrictions for renting a car?</h3>
        <p id="answer4" style="display: none;">A: Yes, there are age restrictions. Generally, you must be at least 21 years old to rent a car. Additional fees may apply for drivers under 25.</p>
    </div>

        <div class="faq">
            <h3 onclick="toggleAnswer(5)">Q: What types of payment are accepted?</h3>
            <p id="answer5" style="display: none;">A: We currently accept payments via Bkash online. In the future, we plan to add major credit cards, including Visa, MasterCard, and possibly Debit cards. Please check with our staff for specific details.</p>
        </div>

    </section>

    <section id="contact">
        <div class="contact-container">
            <form action="https://api.web3forms.com/submit" method="POST" class="contact-left">
                <div class="contact-left-title">
                    <h2>Contact Us</h2>
                    <hr />
                </div>
                <input type="hidden" name="access_key" value="4813d3ab-92ef-40e0-b12c-5601a7c55d7b" />
                <label for="name">Name:</label>
                <input type="text" id="name" name="name" class="contact-inputs" required>

                <label for="email">Email:</label>
                <input type="email" id="email" name="email" class="contact-inputs" required>

                <label for="message">Message:</label>
                <textarea id="message" name="message" rows="4" class="contact-inputs" required></textarea>

                <button type="submit">Submit</button>
            </form>
            <div class="contact-right">
                <img src="../Assets/Img/contact.png" alt="" />
            </div>
        </div>
    </section>

    <script>
        function toggleAnswer(id) {
            var answer = document.getElementById('answer' + id);
            if (answer.style.display === 'none') {
                answer.style.display = 'block';
            } else {
                answer.style.display = 'none';
            }
        }
    </script>

    <script>
        let slideIndex = 0;

        function showSlides() {
            let slides = document.getElementsByClassName("mySlides");
            let dots = document.getElementsByClassName("dot");

            for (let i = 0; i < slides.length; i++) {
                slides[i].style.display = "none";
            }

            slideIndex++;

            if (slideIndex > slides.length) {
                slideIndex = 1;
            }

            for (let i = 0; i < dots.length; i++) {
                dots[i].className = dots[i].className.replace(" active", "");
            }

            slides[slideIndex - 1].style.display = "block";
            dots[slideIndex - 1].className += " active";

            setTimeout(showSlides, 3000);
        }
        showSlides();
    </script>

</body>

</html>


