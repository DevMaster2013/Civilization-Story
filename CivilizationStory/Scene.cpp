#include "stdafx.h"
#include "Scene.h"
#include "Game.h"

Scene::Scene(Game* game)
	: _game(game)
{
	
}

Scene::~Scene()
{
	
}

void Scene::init()
{
	create_scene();
}

void Scene::exit()
{	
	_desktop.RemoveAll();
}

void Scene::handle_events(sf::Event event)
{
	_desktop.HandleEvent(event);
	handle_scene_events(event);
}

void Scene::update(float elapsedSeconds)
{	
	update_scene(elapsedSeconds);
	_desktop.Update(elapsedSeconds);
}

void Scene::render()
{
	render_scene();
}

void Scene::render_gui()
{
	_game->getSFGUI().Display(_game->getRenderWindow());
}

void Scene::create_scene()
{
}

void Scene::handle_scene_events(sf::Event event)
{
}

void Scene::update_scene(float elapsedSeconds)
{
}

void Scene::render_scene()
{
}
