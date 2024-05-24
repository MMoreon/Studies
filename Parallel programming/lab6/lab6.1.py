import numpy as np


def qft(state):
    n = len(state)
    for i in range(n):
        for j in range(i + 1, n):
            state[i], state[j] = np.real(np.exp(
                -1j * np.pi * i * j / n)) * state[i], np.real(
                    np.exp(-1j * np.pi * i * j / n)) * state[j]
    return state


# Функция для вычисления периода функции
def compute_period(state):
    n = len(state)
    for i in range(1, n):
        if np.allclose(state, np.roll(state, i)):
            return i


# Функция для факторизации числа с использованием периода
def factorize(n, period):
    a = int(np.sqrt(n))
    b = n // a
    return a, b


def main():
    # Составьте число, которое хотите разложить на множители
    n = 25

    # Создайте суперпозицию всех целых чисел от 0 до n-1
    state = np.array([1 / np.sqrt(n)] * n)

    # Примените QFT к состоянию
    qft_state = qft(state)

    # Измерьте состояние суперпозиции
    probabilities = np.abs(qft_state)**2
    probabilities /= np.sum(probabilities)
    measured_state = np.random.choice(range(n), p=probabilities)

    # Вычислите период функции
    period = compute_period(qft_state)

    # Факторизуйте n с использованием периода
    a, b = factorize(n, period)

    print(f"Факторы числа {n}: {a}, {b}")


if __name__ == "__main__":
    main()
