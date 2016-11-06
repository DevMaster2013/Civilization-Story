#pragma once
#include "Scene.h"

class MainMenuScene : public Scene
{
private:
	std::shared_ptr<sfg::Button> _startGameButton;
	std::shared_ptr<sfg::Button> _exitGameButton;
	std::shared_ptr<sfg::Box> _layoutBox;

public:
	MainMenuScene(Game* game);
	~MainMenuScene();

private:
	void onStartGameButtonClick();
	void onExitGameButtonClick();

private:
	virtual void create_scene();
	virtual void handle_scene_events(sf::Event event);
	virtual void update_scene(float elapsedSeconds);
	virtual void render_scene();
};

