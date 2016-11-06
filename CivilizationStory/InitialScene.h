#pragma once
#include "Scene.h"

class InitialScene : public Scene
{
private:
	std::shared_ptr<sfg::Label> _copyrightLabel;
	std::shared_ptr<sfg::Box> _layoutBox;

public:
	InitialScene(Game* game);
	~InitialScene();

private:
	virtual void create_scene();
	virtual void handle_scene_events(sf::Event event);
	virtual void update_scene(float elapsedSeconds);
	virtual void render_scene();
};

