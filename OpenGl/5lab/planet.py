import pygame
from pygame.locals import *
from OpenGL.GL import *
from OpenGL.GLU import *

class Planet:
    def __init__(self, distance, size, texture_file, rotation_speed):
        self.distance = distance
        self.size = size
        self.texture_file = texture_file
        self.rotation_speed = rotation_speed
        self.angle = 0

    def load_texture(self):
        planet_texture = pygame.image.load(self.texture_file)
        texture_data = pygame.image.tostring(planet_texture, "RGBA", 1)
        width = planet_texture.get_width()
        height = planet_texture.get_height()
        texture_id = glGenTextures(1)
        glBindTexture(GL_TEXTURE_2D, texture_id)
        glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, GL_LINEAR)
        glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, GL_LINEAR)
        glTexImage2D(GL_TEXTURE_2D, 0, GL_RGBA, width, height, 0, GL_RGBA, GL_UNSIGNED_BYTE, texture_data)
        return texture_id

    def draw(self):
        glPushMatrix()
        glRotatef(self.angle * self.rotation_speed, 0, 1, 0)
        glTranslatef(self.distance, 0.0, 0.0)
        glEnable(GL_TEXTURE_2D)
        glBindTexture(GL_TEXTURE_2D, self.texture_id)
        gluQuadricTexture(self.planet, GLU_TRUE)
        gluSphere(self.planet, self.size, 32, 32)
        glPopMatrix()

def load_background_texture(filename):
    background_texture = pygame.image.load(filename)
    background_data = pygame.image.tostring(background_texture, "RGBA", 1)
    width = background_texture.get_width()
    height = background_texture.get_height()
    texture_id = glGenTextures(1)
    glBindTexture(GL_TEXTURE_2D, texture_id)
    glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, GL_LINEAR)
    glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, GL_LINEAR)
    glTexImage2D(GL_TEXTURE_2D, 0, GL_RGBA, width, height, 0, GL_RGBA, GL_UNSIGNED_BYTE, background_data)
    return texture_id

def draw_background(background_texture_id):
    glDisable(GL_DEPTH_TEST)
    glEnable(GL_TEXTURE_2D)
    glBindTexture(GL_TEXTURE_2D, background_texture_id)
    glBegin(GL_QUADS)
    glTexCoord2f(0, 0)
    glVertex2f(-9, -6)
    glTexCoord2f(1, 0)
    glVertex2f(9, -6)
    glTexCoord2f(1, 1)
    glVertex2f(9, 6)
    glTexCoord2f(0, 1)
    glVertex2f(-9, 6)
    glEnd()
    glDisable(GL_TEXTURE_2D)
    glEnable(GL_DEPTH_TEST)

def main():
    pygame.init()
    display = (1280, 720)
    pygame.display.set_mode(display, DOUBLEBUF | OPENGL)

    glEnable(GL_DEPTH_TEST)
    gluPerspective(45, (display[0] / display[1]), 0.1, 50.0)

    planets = [
        Planet(0.1, 0.5, 'solar_texture.jpg', 0.4),
        Planet(1, 0.1, 'venus_texture.jpg', 0.4),
        Planet(1.7, 0.4, 'earth_texture.jpg', 0.2),
        Planet(2.6, 0.4, 'mars_texture.jpg', 0.1),
        Planet(3.3, 0.2, 'jupiter_texture.jpg', 0.5),
        Planet(4.5, 0.8, 'saturn_texture.jpg', 0.3),
        Planet(6.5, 0.7, 'uranus_texture.jpg', 0.2),
        Planet(8.1, 0.6, 'neptune_texture.jpg', 0.1),
        Planet(9.6, 0.6, 'mercury_texture.jpg', 0.05)
    ]

    background_texture_id = load_background_texture('space.jpg')

    for planet in planets:
        planet.planet = gluNewQuadric()
        planet.texture_id = planet.load_texture()

    glTranslatef(0.0, 0.0, -10)
    glRotatef(15, 1, 0, 0)

    angle = 0

    while True:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                pygame.quit()
                quit()

        glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT)

        draw_background(background_texture_id)

        for planet in planets:
            planet.angle = angle
            planet.draw()

        angle += 1
        if angle >= 18000:
            angle = 0

        pygame.display.flip()


if __name__ == "__main__":
    main()


