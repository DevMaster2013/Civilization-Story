#pragma once
#include "Scene.h"

class IntroductionScene : public Scene
{
	std::shared_ptr<sfg::Label> _gameNameLabel;
	std::shared_ptr<sfg::Box> _layoutBox;

public:
	IntroductionScene(Game* game);
	~IntroductionScene();

private:
	virtual void create_scene();
	virtual void handle_scene_events(sf::Event event);
	virtual void update_scene(float elapsedSeconds);
	virtual void render_scene();
};

