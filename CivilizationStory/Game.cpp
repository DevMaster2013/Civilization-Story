#include "stdafx.h"
#include "Game.h"
#include "InitialScene.h"
#include "IntroductionScene.h"
#include "MainGameScene.h"
#include "MainMenuScene.h"
#include "StartGameScene.h"

Game::Game()
	: _currentScene(nullptr)
	, _currentState(UNKNOWN)
	, _satateChanged(false)
{
	init();
}

Game::~Game()
{
}

void Game::init()
{
	_renderWindow.create(sf::VideoMode(SCREEN_WIDTH, SCREEN_HEIGHT), "Civilization Story");
	sfg::Renderer::Set(sfg::VertexArrayRenderer::Create());
	_renderWindow.resetGLStates();

	changeScene(INITIAL);
}

void Game::start()
{
	sf::Event event;
	while (_renderWindow.isOpen()) 
	{
		while (_renderWindow.pollEvent(event))
			handle_events(event);
		update_game(_clock.restart().asSeconds());

		_renderWindow.clear();					
			render_game();		
		_renderWindow.display();
	}
}

void Game::handle_events(sf::Event event)
{
	if (event.type == sf::Event::Closed)
		_renderWindow.close();

	if (_currentScene)
		_currentScene->handle_events(event);

	if (_satateChanged)
		change_game_state();
}

void Game::update_game(float elapsedSeconds)
{
	if (_currentScene)
		_currentScene->update(elapsedSeconds);
}

void Game::render_game()
{
	if (_currentScene)
		_currentScene->render();
}

void Game::change_game_state()
{
	if (_currentScene)
	{
		_currentScene->exit();
		delete _currentScene; _currentScene = nullptr;
	}

	switch (_currentState)
	{
	case INITIAL:
		_currentScene = new InitialScene(this);
		break;
	case INTRODUCTION:
		_currentScene = new IntroductionScene(this);
		break;
	case MAINMENU:
		_currentScene = new MainMenuScene(this);
		break;
	case STARTGAME:
		_currentScene = new StartGameScene(this);
		break;
	case MAINGAME:
		_currentScene = new MainGameScene(this);
		break;
	case EXITGAME:
		_renderWindow.close();
		break;
	default:
		break;
	}

	if (_currentScene)
		_currentScene->init();
	_satateChanged = false;
}

void Game::setCreationInfo(GameCreationInfo creationInfo)
{
	_creationInfo = creationInfo;
}

void Game::changeScene(GameState newState)
{
	if (_currentState == newState)
		return;

	_currentState = newState;	
	_satateChanged = true;
}
