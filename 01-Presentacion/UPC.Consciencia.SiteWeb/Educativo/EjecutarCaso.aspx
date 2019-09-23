﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/LayoutPrincipal.master" AutoEventWireup="true" CodeBehind="EjecutarCaso.aspx.cs" Inherits="UPC.Consciencia.SiteWeb.Educativo.EjecutarCaso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHeader" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">

    <!-- PERCENT LOADER START-->
    	<div id="mainLoader"><img src="../Utilitarios/assets/loader.png" /><br><span>0</span></div>
        <!-- PERCENT LOADER END-->
        
        <!-- CONTENT START-->
        <div id="mainHolder">
        	<div id="option" class="fitImg">
            	<div id="buttonOption" class="buttonClick buttonIcon buttonOptionOff"><img class="optionOff" alt="Begin" src="../Utilitarios/assets/button_option_close.png" /><img class="optionOn" alt="Begin" src="../Utilitarios/assets/button_option.png" /></div>
                <div id="optionList" style="display:none;">
                	<div id="buttonFullscreen" class="buttonClick buttonIcon buttonFullscreen"><img alt="Begin" src="../Utilitarios/assets/button_fullscreen.png" /></div>
                    <div id="buttonSound" class="buttonClick buttonIcon buttonSound buttonSoundOn"><img class="soundOff" alt="Begin" src="../Utilitarios/assets/button_sound_off.png" /><img class="soundOn" alt="Begin" src="../Utilitarios/assets/button_sound_on.png" /></div>
                	<div id="buttonExit" class="buttonClick buttonIcon buttonExit"><img alt="Begin" src="../Utilitarios/assets/button_exit.png" /></div>
                    
                </div>
            </div>
            
            <div id="logoHolder">
            	<div class="mainContent fitImg">
                	<div class="logo"><img src="../Utilitarios/assets/logo.png"/></div>
                    <div class="preloadText fontPreload resizeFont"></div>
            		<div id="buttonStart" class="startImg buttonClick"><img src="../Utilitarios/assets/button_start.png"/></div>
                </div>
            </div>
            
            <div id="confirmHolder" class="overlayBg">
            	<div class="confirmContent">
                	<div class="message fontMessage resizeFont ignorePadding" data-fontSize="30" data-lineHeight="30">Are you sure you want to quit the game?</div>
            		<div id="buttonOk" class="okImg buttonClick fitImg"><img src="../Utilitarios/assets/button_ok.png"/></div>
                	<div id="buttonCancel" class="cancelImg buttonClick fitImg"><img src="../Utilitarios/assets/button_cancel.png"/></div>
                </div>
            </div>
            
            <div id="categoryHolder">
            	<div class="categoryContent fitImg">
                	<div id="buttonNextCat" class="nextImg buttonClick fitImg"><img src="../Utilitarios/assets/button_next.png"/></div>
                    <div id="buttonPrevCat" class="prevImg buttonClick fitImg"><img src="../Utilitarios/assets/button_prev.png"/></div>
                	<ul id="categoryList"></ul>
                </div>
            </div>
            
            <div id="gameHolder">
            	<div id="gameStatus" class="fitImg">
                	<div class="gameTotal fontStatus">
                    	<div class="gameQuestionStatus resizeFont" data-fontSize="30" data-lineHeight="30">1/18</div>
                        <img class="soundOn" alt="Begin" src="../Utilitarios/assets/item_question.png" />
                    </div>
                    <div class="gameTimer fontStatus">
                    	<div class="gameTimerStatus resizeFont" data-fontSize="30" data-lineHeight="30">35</div>
                        <img class="soundOn" alt="Begin" src="../Utilitarios/assets/item_timer.png" />
                    </div>
                </div>
                
                <div id="questionLoaderHolder">
                	
                </div>
                
            	<div id="questionHolder">
                	<div class="questionText fontQuestion">How much is 150% of 50<br/>How much is 150% of 50</div>
                </div>
                
                <div id="questionResultHolder">
                	<div id="explanationHolder"></div>
                    <div class="questionResultText fontCorrectWrong"></div>
                    <div id="buttonNextQues" class="nextImg fontCorrectWrong buttonClick fitImg"><img src="../Utilitarios/assets/button_next.png"/></div>
                    <div id="buttonPreviewQues" class="previewImg fontCorrectWrong buttonClick fitImg"><img src="../Utilitarios/assets/button_preview.png"/></div>
                </div>
            </div>
            
            <div id="resultHolder">
            	<div class="resultExtra overlayBg fitImg">
                    <div class="submitContent">
                        <div class="fontSubmitTitle resizeFont submitTitle" data-fontSize="50" data-lineHeight="50"></div>
                        <div class="fontLabel label resizeFont">Name:</div>
                        <input id="uName" name="uName" type="text" class="fontInput resizeFont">
                        <div class="fontLabel label resizeFont">Email:</div>
                        <input id="uEmail" name="uEmail" type="text" class="fontInput resizeFont">
                        <div class="action">
                        	<div id="buttonSubmit" class="buttonSubmit buttonClick"><img src="../Utilitarios/assets/button_submit.png"/></div>
                            <div id="buttonCancelSubmit" class="buttonCancelSubmit buttonClick"><img src="../Utilitarios/assets/button_cancel.png"/></div>
                        </div>
                    </div>
                    <div class="scoreContent">
                        <div class="fontScoreTitle resizeFont scoreTitle" data-fontSize="50" data-lineHeight="50"></div>
                        <ul class="scoreList">
                        	
                        </ul>
                        <div id="buttonBack" class="buttonBack buttonClick"><img src="../Utilitarios/assets/button_back.png"/></div>
                    </div>
                </div>
                
            	<div class="resultContent fitImg">
                	<div class='itemWinnerCup'><img src="../Utilitarios/assets/item_cup.png" /></div>
                    
                    <div id='resultScore' class="fontResultScore fontScore resizeFont" data-fontSize="50" data-lineHeight="50">100</div>
                    <div class="option singleOption">
                        <ul>
                            <li id="buttonReplay" class="buttonClick fitImg"><img alt="Replay" src="../Utilitarios/assets/button_replay.png" /></li>
                            <li id="buttonSave" class="buttonClick fitImg"><img alt="Replay" src="../Utilitarios/assets/button_save.png" /></li>
                            <li id="buttonScore" class="buttonClick fitImg"><img alt="Replay" src="../Utilitarios/assets/button_score.png" /></li>
                        </ul>
                    </div>
                    <div id="shareOption" class="share">
                        <div class="fontShare resizeFont" data-fontSize="30" data-lineHeight="30">Share you score</div>
                        <ul>
                            <li id="buttonFacebook" class="buttonClick fitImg"><img alt="Facebook" src="../Utilitarios/assets/button_facebook.png" /></li>
                            <li id="buttonTwitter" class="buttonClick fitImg"><img alt="Twitter" src="../Utilitarios/assets/button_twitter.png" /></li>
                            <li id="buttonGoogle" class="buttonClick fitImg"><img alt="Google" src="../Utilitarios/assets/button_google.png" /></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <!-- CONTENT END-->

</asp:Content>