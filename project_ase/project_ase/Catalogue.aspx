<%@ Page Title="" Language="C#" MasterPageFile="~/interior-design/MasterPage.master" AutoEventWireup="true" CodeFile="Catalogue.aspx.cs" Inherits="interior_design_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">

    <section id="content">
  <div class="bg-top">
    <div class="bg-top-2">
      <div class="bg">
        <div class="bg-top-shadow">
          <div class="main">
            <div class="gallery p3">
              <div class="wrapper indent-bot">
                <div id="gallery" class="content">
                  <div class="wrapper">
                    <div class="slideshow-container">
                      <div id="slideshow" class="slideshow"></div>
                    </div>
                  </div>
                </div>
                <div id="thumbs" class="navigation">
                  <ul class="thumbs noscript">
                    <li> <a class="thumb" href="images/uqueryvanswer.PNG"> <img src="images/uqueryvanswer.PNG" height="300" width="300" alt=""><span></span> </a> </li>
                    <li> <a class="thumb" href="images/gre.PNG"> <img src="images/gre.PNG"  height="100" width="100" alt=""> <span></span></a> </li>
                    <li> <a class="thumb" href="images/toefl.PNG"> <img src="images/toefl.PNG"  height="100" width="100" alt=""> <span></span></a> </li>
                    <li> <a class="thumb" href="images/list.PNG"> <img src="images/list.PNG"  height="100" width="100" alt=""> <span></span></a> </li>
                    <li> <a class="thumb" href="images/assesment.PNG"> <img src="images/assesment.PNG"  height="100" width="100" alt=""> <span></span></a> </li>
                  </ul>
                </div>
              </div>
              <div class="inner-2">
                <div class="wrapper"><span><a href="Services.aspx"> <input class="title t2 img-indent3"  id="Shop_Now" type="button" value="Start your Preperation" /></a></span>
                  <div class="extra-wrap indent-top2">Keep in touch with us and make your preparation easy..! </div>
                </div>
              </div>
            </div>
            <div class="carousel"
              <a class="prev" href="#">Prev</a> <a class="next" href="#">Next</a>
              </div>
          </div>
        </div>
      </div>
    </div>
  </div>
 
</section>

</asp:Content>

