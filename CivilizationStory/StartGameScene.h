#pragma once
#include "Scene.h"

class StartGameScene : public Scene
{
private:
	std::shared_ptr<sfg::Button> _startGameButton;
	std::shared_ptr<sfg::Entry> _entryPlayerName;
	std::shared_ptr<sfg::Entry> _entryFactionName;
	std::shared_ptr<sfg::Label> _labelPlayerName;
	std::shared_ptr<sfg::Label> _labelFactionName;

	std::shared_ptr<sfg::Box> _playerNameLayoutBox;
	std::shared_ptr<sfg::Box> _factionNameLayoutBox;
	std::shared_ptr<sfg::Box> _layoutBox;

public:
	StartGameScene(Game* game);
	~StartGameScene();

private:
	virtual void create_scene();
	virtual void handle_scene_events(sf::Event event);
	virtual void update_scene(float elapsedSeconds);
	virtual void render_scene();

private:
	void onStartGameButtonClick();
};

