////////////////////////////////////////////////////////////
// CANVAS LOADER
////////////////////////////////////////////////////////////

 /*!
 * 
 * START CANVAS PRELOADER - This is the function that runs to preload canvas asserts
 * 
 */
function initPreload(){
	toggleLoader(true);
	
	$(window).resize(function(){
		resizeGameFunc();
	});
	resizeGameFunc();
	
	loader = new createjs.LoadQueue(false);
	manifest=[
			{src:'/Utilitarios/assets/logo.png', id:'logo'},
            {src:'/Utilitarios/assets/item_timer.png', id:'itemTimer'},
			{src:'/Utilitarios/assets/item_question.png', id:'itemQuestion'},
			{src:'/Utilitarios/assets/item_cup_over.png', id:'itemCupOver'},
			{src:'/Utilitarios/assets/item_cup.png', id:'itemCup'},
			{src:'/Utilitarios/assets/bg_pixel.png', id:'bgPixel'},
			
			{src:'/Utilitarios/assets/button_facebook.png', id:'buttonFacebook'},
			{src:'/Utilitarios/assets/button_twitter.png', id:'buttonTwitter'},
			{src:'/Utilitarios/assets/button_google.png', id:'buttonGoogle'},
			{src:'/Utilitarios/assets/button_fullscreen.png', id:'buttonFullscreen'},
			{src:'/Utilitarios/assets/button_sound_on.png', id:'buttonSoundOn'},
			{src:'/Utilitarios/assets/button_sound_off.png', id:'buttonSoundOff'},
			{src:'/Utilitarios/assets/button_replay.png', id:'buttonReplay'},
			{src:'/Utilitarios/assets/button_start.png', id:'buttonStart'},
			{src:'/Utilitarios/assets/button_submit.png', id:'buttonSubmit'},
			{src:'/Utilitarios/assets/button_prev.png', id:'buttonPrev'},
			{src:'/Utilitarios/assets/button_preview.png', id:'buttonPreview'},
			{src:'/Utilitarios/assets/button_replay.png', id:'buttonReplay'},
			{src:'/Utilitarios/assets/button_save.png', id:'buttonSave'},
			{src:'/Utilitarios/assets/button_score.png', id:'buttonScore'},
			{src:'/Utilitarios/assets/button_ok.png', id:'buttonOk'},
			{src:'/Utilitarios/assets/button_next.png', id:'buttonNext'},
			{src:'/Utilitarios/assets/button_exit.png', id:'buttonExit'},
			{src:'/Utilitarios/assets/button_cancel.png', id:'buttonCancel'},
			{src:'/Utilitarios/assets/button_back.png', id:'buttonBack'},
			{src:'/Utilitarios/assets/button_option.png', id:'buttonOption'},
			{src:'/Utilitarios/assets/button_option_close.png', id:'buttonOptionClose'}];
	
	soundOn = true;		
	if($.browser.mobile || isTablet){
		if(!enableMobileSound){
			soundOn=false;
		}
	}
	
	if(soundOn){
		manifest.push({src:'/Utilitarios/assets/sounds/selectAnswer.ogg', id:'soundSelectAnswer'});
		manifest.push({src:'/Utilitarios/assets/sounds/selectWrong.ogg', id:'soundSelectWrong'});
		manifest.push({src:'/Utilitarios/assets/sounds/answerCorrect.ogg', id:'soundAnswerCorrect'});
		manifest.push({src:'/Utilitarios/assets/sounds/answerWrong.ogg', id:'soundAnswerWrong'});
		manifest.push({src:'/Utilitarios/assets/sounds/click.ogg', id:'soundClick'});
		manifest.push({src:'/Utilitarios/assets/sounds/result.ogg', id:'soundResult'});
		
		createjs.Sound.alternateExtensions = ["mp3"];
		loader.installPlugin(createjs.Sound);
	}
	
	loader.addEventListener("complete", handleComplete);
	loader.addEventListener("fileload", fileComplete);
	loader.addEventListener("error",handleFileError);
	loader.on("progress", handleProgress, this);
	loader.loadManifest(manifest);
}

/*!
 * 
 * CANVAS FILE COMPLETE EVENT - This is the function that runs to update when file loaded complete
 * 
 */
function fileComplete(evt) {
	var item = evt.item;
	//console.log("Event Callback file loaded ", evt.item.id);
}

/*!
 * 
 * CANVAS FILE HANDLE EVENT - This is the function that runs to handle file error
 * 
 */
function handleFileError(evt) {
	//console.log("error ", evt);
}

/*!
 * 
 * CANVAS PRELOADER UPDATE - This is the function that runs to update preloder progress
 * 
 */
function handleProgress() {
	$('#mainLoader span').html(Math.round(loader.progress/1*100)+'%');
}

/*!
 * 
 * CANVAS PRELOADER COMPLETE - This is the function that runs when preloader is complete
 * 
 */
function handleComplete() {
	toggleLoader(false);
	initMain();
};

/*!
 * 
 * TOGGLE LOADER - This is the function that runs to display/hide loader
 * 
 */
function toggleLoader(con){
	if(con){
		$('#mainLoader').show();
		$('#mainHolder').hide();
	}else{
		$('#mainLoader').hide();
		$('#mainHolder').show();
	}
}