using System;
using System.Collections;
using System.Collections.Generic;

public class Book
{
    public List<string> contents;
    public Book(List<string> _contents)
    {
        contents = _contents;
    }
}

public class Theatre
{
    public int[] acts;
    public Theatre(int [] _acts)
    {
        acts = _acts;
    }

    public MultimediaIterator CreateIterator()
    {
        return new TheatricalActIterator(acts);
    }
}

public interface MultimediaIterator : IEnumerable
{
    public bool HasNext();
    public object Next();
}

public class BookIterator : MultimediaIterator
{
    List<string> chapters;
    int m_currentChapterIndex = 0;

    public BookIterator(List<string> chapters, int currentChapterIndex)
    {
        this.chapters = chapters;
        m_currentChapterIndex = currentChapterIndex;
    }

    public IEnumerator GetEnumerator()
    {
        return chapters.GetEnumerator();
    }

    public bool HasNext()
    {
        if (m_currentChapterIndex > chapters.Count - 1)
        {
            return false;
        }
        else
        {
            return true;

        }
    }

    public object Next()
    {
        object nextChapter = chapters[m_currentChapterIndex];
        m_currentChapterIndex++;
        return nextChapter;
    }
}


public class TheatricalActIterator : MultimediaIterator
{
    int [] m_theatricalActs;
    int m_currentAct = 0;

    public TheatricalActIterator(int[] theatricalActs)
    {
        m_theatricalActs = theatricalActs; 
    }

    public IEnumerator GetEnumerator()
    {
        return m_theatricalActs.GetEnumerator();
    }

    public bool HasNext()
    {
        if (m_currentAct > m_theatricalActs.Length - 1)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public object Next()
    {
        object nextAct = m_theatricalActs[m_currentAct];
        m_currentAct++;
        return nextAct;
    }
}


