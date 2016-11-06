#include "stdafx.h"
#include "InitialScene.h"
#include "Game.h"

InitialScene::InitialScene(Game* game)
	: Scene(game)
{
}


InitialScene::~InitialScene()
{
}

void InitialScene::create_scene()
{
	_copyrightLabel = sfg::Label::Create("Copyrights reserved for Ahmed Yasser!");

	_layoutBox = sfg::Box::Create(sfg::Box::Orientation::VERTICAL, 5.0f);
	_layoutBox->Pack(_copyrightLabel);

	_desktop.Add(_layoutBox);
}

void InitialScene::handle_scene_events(sf::Event event)
{
	if (event.type == sf::Event::KeyPressed)
	{
		if (event.key.code == sf::Keyboard::Escape)
			_game->changeScene(INTRODUCTION);
	}
}

void InitialScene::update_scene(float elapsedSeconds)
{
	
}

void InitialScene::render_scene()
{
	render_gui();
}
