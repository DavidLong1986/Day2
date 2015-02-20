<%@ Page Title="" Language="C#" MasterPageFile="~/PresentationLayer/C2.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="AmazingTeam.PresentationLayer.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <div class="container">
    <div id="myCarousel" class="carousel slide" data-ride="carousel">
    <!-- Indicators -->
    <ol class="carousel-indicators">
        <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
        <li data-target="#myCarousel" data-slide-to="1"></li>
        <li data-target="#myCarousel" data-slide-to="2"></li>
    </ol>
    <div class="carousel-inner">
        <div class="item active">
            <img src="http://placehold.it/900x500/777777&text=First+slide" alt="First slide">
            <div class="container">
                <div class="carousel-caption">
                    <h1>Example headline.</h1>
                    <p>Note: If you're viewing this page via a <code>file://</code> URL, the "next" and "previous" Glyphicon buttons on the left and right might not load/display properly due to web browser security rules.</p>
                    
                </div>
            </div>
        </div>
        <div class="item">
            <img src="http://placehold.it/900x500/666666&text=Second+slide" alt="Second slide">
            <div class="container">
                <div class="carousel-caption">
                    <h1>Another example headline.</h1>
                    <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                    
                </div>
            </div>
        </div>
        <div class="item">
            <img src="http://placehold.it/900x500/555555&text=Third+slide" alt="Third slide">
            <div class="container">
                <div class="carousel-caption">
                    <h1>One more for good measure.</h1>
                    <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                </div>
            </div>
        </div>
    </div>
    <a class="left carousel-control" href="#myCarousel" data-slide="prev" role="button"><span class="glyphicon glyphicon-chevron-left"></span></a>
    <a class="right carousel-control" href="#myCarousel" data-slide="next" role="button"><span class="glyphicon glyphicon-chevron-right"></span></a>

</div><!-- /.carousel -->



<!-- Marketing messaging and featurettes
    ================================================== -->
<!-- Wrap the rest of the page in another container to center all the content. -->

    

<div class="container marketing" style="padding-top: 10px;" >

    <!-- Three columns of text below the carousel -->
    <div class="row">
        <div class="col-lg-6">
            <img class="img-circle" src="http://coolblackppt.com/wp-content/uploads/2013/08/Smiley-face-background-1280x1024-pixels-wallpapers-tagged-cute-fun-140x140.jpg" alt="Generic placeholder image">
            <h2>Heading</h2>
            <p>Donec sed odio dui. Etiam porta sem malesuada magna mollis euismod. Nullam id dolor id nibh ultricies vehicula ut id elit. Morbi leo risus, porta ac consectetur ac, vestibulum at eros. Praesent commodo cursus magna.</p>
        
        </div><!-- /.col-lg-4 -->
        <div class="col-lg-6">
           <a href="https://www.facebook.com/pages/C2-Desserts-nmore/778029785613719"><img class="img-circle" src="http://www.adobe.com/digitalimag/consumer/partneroffers/photos/images/facebook_140x140.jpg" alt="Generic placeholder image"></a>
            <h2>Heading</h2>
            <p>Duis mollis, est non commodo luctus, nisi erat porttitor ligula, eget lacinia odio sem nec elit. Cras mattis consectetur purus sit amet fermentum. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh.</p>
        </div><!-- /.col-lg-4 -->
    </div><!-- /.row -->





      <footer style="padding-top:30px;">
        <p>&copy; 2015 C2, Inc. &middot; Web Site Develop by: Amazing Team &middot; <a href="Authenticate.aspx" style="color:deeppink">Staff Login</a></p>
    </footer>

</div><!-- /.container -->

</div>
</asp:Content>
