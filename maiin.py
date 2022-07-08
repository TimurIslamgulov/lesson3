x1=input('введите первое число')

try:
    x1=float(x1)
except:
    print('надо было ввести целое число')

z=x1%1 - x1%0.1
print( round(z*10) )
'''
def summa(a,b):
    z=a+b- 
    print(f'сумма равна {z}')
    return z
'''
#summa(x1,x2)
