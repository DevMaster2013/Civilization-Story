#pragma once

class Game;
class Scene
{
protected:
	Game* _game;
	sfg::Desktop _desktop;
	bool _shouldClosed;

public:
	Scene(Game* game);
	virtual ~Scene();

public:
	void init();
	void exit();
	void handle_events(sf::Event event);
	void update(float elapsedSeconds);
	void render();

protected:
	void render_gui();

protected:
	virtual void create_scene();
	virtual void handle_scene_events(sf::Event event);
	virtual void update_scene(float elapsedSeconds);
	virtual void render_scene();
};

