#pragma once
#include "Scene.h"

class MainGameScene : public Scene
{
public:
	MainGameScene(Game* game);
	~MainGameScene();

private:
	virtual void create_scene();
	virtual void handle_scene_events(sf::Event event);
	virtual void update_scene(float elapsedSeconds);
	virtual void render_scene();
};

