<%@ Page Title="" Language="C#" MasterPageFile="~/interior-design/MasterPage.master" AutoEventWireup="true" CodeFile="Contact Us.aspx.cs" Inherits="interior_design_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BodyContent" Runat="Server">
<section id="content">
  <div class="bg-top">
    <div class="bg-top-2">
      <div class="bg">
        <div class="bg-top-shadow">
          <div class="main">
            <div class="box">
              <div class="padding">
                <div class="container_12">
                  <div class="wrapper">
                    <div class="grid_12">
                      <div class="indent-left">
                        <h3 class="p2">Contact Form</h3>
                        <form id="contact-form" action="#" method="post" enctype="multipart/form-data">
                          <fieldset>
                            <label><span class="text-form">Name:</span>
                              <input name="p1" type="text">
                            </label>
                            <label><span class="text-form">Email:</span>
                              <input name="p2" type="text">
                            </label>
                            <label><span class="text-form">Phone:</span>
                              <input name="p3" type="text">
                            </label>
                            <div class="wrapper">
                              <div class="text-form">Message:</div>
                              <textarea></textarea>
                            </div>
                            <div class="buttons"> <a class="button" href="#">Clear</a> <a class="button" href="#">Send</a> </div>
                          </fieldset>
                        </form>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
  <div class="bg-bot">
    <div class="main">
      <div class="container_12">
        <div class="wrapper">
          <article class="grid_3">
            <h3 class="prev-indent-bot">Our Address</h3>
            <dl>
              <dt class="indent-bot">4916,Grand Avenue,kansas city<br>
                Missouri-64112.</dt>
              
              <dd><span>Telephone:</span> +1 </dd>816 810 5149
              <dd><span>FAX:</span> +1 504 889 9898</dd>
              <dd><strong>E-mail:</strong> <a href="#">sadmb@mail.umkc.edu</a></dd>
            </dl>
          </article>
          <article class="grid_9">
            <h3 class="prev-indent-bot">Miscellaneous Info</h3>
            <strong>Terms and Conditions</strong>Apply* </article>
        </div>
      </div>
    </div>
  </div>
</section>
</asp:Content>

