import pygame
import concurrent.futures
import numpy as np

# Параметры окна
WIDTH, HEIGHT = 640, 320
FPS = 60

# Параметры шара
BALL_SIZE = 10
NUM_BALLS = 5

# Начальные условия для шаров
balls = [{
    'pos': np.array([np.random.rand() * WIDTH, np.random.rand() * HEIGHT]),
    'vel': np.random.rand(2) * 2 - 1,
    'color': (np.random.randint(0, 256), np.random.randint(0, 256), np.random.randint(0, 256))
} for _ in range(NUM_BALLS)]

def move_ball(ball):
    ball['pos'] += ball['vel']

    # Отражение от стен
    if ball['pos'][0] <= 0 or ball['pos'][0] >= WIDTH:
        ball['vel'][0] *= -1
    if ball['pos'][1] <= 0 or ball['pos'][1] >= HEIGHT:
        ball['vel'][1] *= -1
    return ball

def main():
    pygame.init()
    screen = pygame.display.set_mode((WIDTH, HEIGHT))
    clock = pygame.time.Clock()

    running = True
    while running:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                running = False

        # Параллельное вычисление новых позиций шаров
        with concurrent.futures.ThreadPoolExecutor() as executor:
            balls[:] = list(executor.map(move_ball, balls))

        # Отрисовка
        screen.fill((0, 0, 0))
        for ball in balls:
            pygame.draw.circle(screen, ball['color'], ball['pos'].astype(int), BALL_SIZE)

        pygame.display.flip()
        clock.tick(FPS)

    pygame.quit()

if __name__ == "__main__":
    main()
