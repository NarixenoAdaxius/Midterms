
stack = []
mem = ''
counter = 0

print('\nWelcome User')

while True:
    print('\n----------------MENU----------------')
    print('[A] Add familly member')
    print('[B] Remove recently added familty member')
    print('[C] Display recently added familly member')
    print('[D] Display saved family members')
    print('[E] Exit program')
    
    
    choice = input('\nEnter Choice(A-E): ')
    
    if choice == 'A' : 
        mem = input('Enter a Family member:')
        stack.append(mem)
    elif choice == 'B' : 
        stack.pop()
        print('Successful')
    elif choice == 'C': 
        print('Recently Added Familly member')
        print(stack[-1])
    elif choice == 'D': 
        print('Family members')
        print(stack)
    elif choice == 'E':
        print('Goodbye User')
        break
    else:
        print('Invalid Input')

