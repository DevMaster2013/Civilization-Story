#include "stdafx.h"
#include "StartGameScene.h"
#include "Game.h"

StartGameScene::StartGameScene(Game* game)
	: Scene(game)
{
}


StartGameScene::~StartGameScene()
{
}

void StartGameScene::create_scene()
{
	_layoutBox = sfg::Box::Create(sfg::Box::Orientation::VERTICAL, 5.0f);
	_playerNameLayoutBox = sfg::Box::Create(sfg::Box::Orientation::HORIZONTAL, 5.0f);
	_factionNameLayoutBox = sfg::Box::Create(sfg::Box::Orientation::HORIZONTAL, 5.0f);

	_layoutBox->SetPosition(sf::Vector2f(200.0f, 210.0f));
	_playerNameLayoutBox->SetRequisition(sf::Vector2f(400.0f, 30.0f));
	_factionNameLayoutBox->SetRequisition(sf::Vector2f(400.0f, 30.0f));

	_startGameButton = sfg::Button::Create("Start Game");
	_startGameButton->GetSignal(sfg::Widget::OnLeftClick).Connect(std::bind(&StartGameScene::onStartGameButtonClick, this));

	_entryPlayerName = sfg::Entry::Create("Player"); _entryPlayerName->SetRequisition(sf::Vector2f(300.0f, 30.0f));
	_entryFactionName = sfg::Entry::Create("Faction"); _entryFactionName->SetRequisition(sf::Vector2f(300.0f, 30.0f));
	_labelPlayerName = sfg::Label::Create("Player Name:"); _labelPlayerName->SetRequisition(sf::Vector2f(100.0f, 30.0f));
	_labelFactionName = sfg::Label::Create("Faction Name:"); _labelFactionName->SetRequisition(sf::Vector2f(100.0f, 30.0f));

	_playerNameLayoutBox->Pack(_labelPlayerName);
	_playerNameLayoutBox->Pack(_entryPlayerName);

	_factionNameLayoutBox->Pack(_labelFactionName);
	_factionNameLayoutBox->Pack(_entryFactionName);

	_layoutBox->Pack(_playerNameLayoutBox);
	_layoutBox->Pack(_factionNameLayoutBox);
	_layoutBox->Pack(_startGameButton);

	_desktop.Add(_layoutBox);
}

void StartGameScene::handle_scene_events(sf::Event event)
{
	if (event.type == sf::Event::KeyPressed)
	{
		if (event.key.code == sf::Keyboard::Escape)
			_game->changeScene(MAINMENU);
	}
}

void StartGameScene::update_scene(float elapsedSeconds)
{
}

void StartGameScene::render_scene()
{
	render_gui();
}

void StartGameScene::onStartGameButtonClick()
{
	GameCreationInfo info;
	info.factionName = _entryFactionName->GetText();
	info.playerName = _entryPlayerName->GetText();
	_game->setCreationInfo(info);
	_game->changeScene(MAINGAME);
}
