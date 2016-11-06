#include "stdafx.h"
#include "IntroductionScene.h"
#include "Game.h"

IntroductionScene::IntroductionScene(Game* game)
	: Scene(game)
{
}


IntroductionScene::~IntroductionScene()
{
}

void IntroductionScene::create_scene()
{
	_gameNameLabel = sfg::Label::Create("Civilization Story!");

	_layoutBox = sfg::Box::Create(sfg::Box::Orientation::VERTICAL, 5.0f);
	_layoutBox->Pack(_gameNameLabel);

	_desktop.Add(_layoutBox);
}

void IntroductionScene::handle_scene_events(sf::Event event)
{
	if (event.type == sf::Event::KeyPressed)
	{
		if (event.key.code == sf::Keyboard::Escape)
			_game->changeScene(MAINMENU);
	}
}

void IntroductionScene::update_scene(float elapsedSeconds)
{
}

void IntroductionScene::render_scene()
{
	render_gui();
}
