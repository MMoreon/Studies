import numpy as np

# Измеренное состояние
measured_state = np.array([0.5, 0.6, 0.5, 0.5])

# Вычислите автокорреляцию
autocorrelation = np.correlate(measured_state, measured_state, mode='full')

# Найдите пик в автокорреляции
peak_index = np.argmax(autocorrelation)

# Определите порядок
order = peak_index

print(f"Порядок: {order}")