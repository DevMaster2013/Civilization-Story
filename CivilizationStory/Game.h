#pragma once

#include "Scene.h"

enum GameState
{
	UNKNOWN,
	INITIAL,
	INTRODUCTION,
	MAINMENU,
	STARTGAME,
	MAINGAME,
	EXITGAME
};

struct GameCreationInfo
{
	sf::String playerName;
	sf::String factionName;
};

class Game
{
	const int SCREEN_WIDTH = 800;
	const int SCREEN_HEIGHT = 600;

private:
	sf::RenderWindow _renderWindow;
	sfg::SFGUI _sfgui;
	sf::Clock _clock;

	Scene* _currentScene;
	GameState _currentState;
	bool _satateChanged;

	GameCreationInfo _creationInfo;

public:
	Game();
	~Game();

public:	
	void start();
	void changeScene(GameState newState);

private:
	void init();
	void handle_events(sf::Event event);
	void update_game(float elapsedSeconds);
	void render_game();	
	void change_game_state();

public:
	void setCreationInfo(GameCreationInfo creationInfo);

public:
	sf::RenderWindow& getRenderWindow() { return _renderWindow; }
	sfg::SFGUI& getSFGUI() { return _sfgui; }
	sf::Clock& getClock() { return _clock; }
};

