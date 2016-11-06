#include "stdafx.h"
#include "MainMenuScene.h"
#include "Game.h"

MainMenuScene::MainMenuScene(Game* game)
	: Scene(game)
{
}

MainMenuScene::~MainMenuScene()
{
}

void MainMenuScene::create_scene()
{
	_startGameButton = sfg::Button::Create("Start Game");
	_exitGameButton = sfg::Button::Create("Exit Game");

	_startGameButton->GetSignal(sfg::Widget::OnLeftClick).Connect(std::bind(&MainMenuScene::onStartGameButtonClick, this));
	_exitGameButton->GetSignal(sfg::Widget::OnLeftClick).Connect(std::bind(&MainMenuScene::onExitGameButtonClick, this));

	_layoutBox = sfg::Box::Create(sfg::Box::Orientation::VERTICAL, 5.0f);	
	_layoutBox->SetPosition(sf::Vector2f(300.0f, 270.0f));
	_layoutBox->SetRequisition(sf::Vector2f(200.0f, 30.0f));

	_layoutBox->Pack(_startGameButton);
	_layoutBox->Pack(_exitGameButton);

	_desktop.Add(_layoutBox);
}

void MainMenuScene::onStartGameButtonClick()
{
	_game->changeScene(STARTGAME);
}

void MainMenuScene::onExitGameButtonClick()
{
	_game->changeScene(EXITGAME);
}

void MainMenuScene::handle_scene_events(sf::Event event)
{
}

void MainMenuScene::update_scene(float elapsedSeconds)
{
}

void MainMenuScene::render_scene()
{
	render_gui();
}
