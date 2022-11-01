from textblob import Word
import re
import sys
def check_word_spelling(word):
    word = Word(word)

    result = word.spellcheck()

    if word == result[0][0]:
        print(True)
    else:
        print(False)

def check_sentence_spelling(sentence):
    words = sentence.split()

    words = [word.lower() for word in words]

    words = [re.sub(r'[^A-Za-z0-9]+', '', word) for word in words]

    for word in words:
        check_word_spelling(word)
sen = input("Enter the string:")
check_sentence_spelling(sen)

