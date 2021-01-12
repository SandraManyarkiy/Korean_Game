using UnityEngine.SceneManagement;
using UnityEngine;

public class Manager5 : MonoBehaviour
{
    public GameObject Chue, Song, Ham, Ni, Da, ChueAns, SongAns, HamAns, NiAns, DaAns;
    Vector2 ChueInitialPos, SongInitialPos, HamInitialPos, NiInitialPos, DaInitialPos;

    public AudioSource source;
    public AudioClip[] Chuecorrect;
    public AudioClip[] Songcorrect;
    public AudioClip[] Hamcorrect;
    public AudioClip[] Nicorrect;
    public AudioClip[] Dacorrect;
    public AudioClip incorrect;

    bool ChueCorrect, SongCorrect, HamCorrect, NiCorrect, DaCorrect = false;
    void Start()
    {
        ChueInitialPos = Chue.transform.position;
        SongInitialPos = Song.transform.position;
        HamInitialPos = Ham.transform.position;
        NiInitialPos = Ni.transform.position;
        DaInitialPos = Da.transform.position;

    }

    public void DragChue()
    {
         Chue.transform.position = Input.mousePosition;
    }

    public void DragSong()
    {
        Song.transform.position = Input.mousePosition;
    }

    public void DragHam()
    {
        Ham.transform.position = Input.mousePosition;
    }

    public void DragNi()
    {
        Ni.transform.position = Input.mousePosition;
    }

    public void DragDa()
    {
        Da.transform.position = Input.mousePosition;
    }

    public void DropChue()
    {
        float Distance = Vector3.Distance(Chue.transform.position, ChueAns.transform.position);
        if (Distance < 50)
        {
            Chue.transform.position = ChueAns.transform.position;
            DBManager.scoreValue += 2;
            source.clip = Chuecorrect[Random.Range(0, Chuecorrect.Length)];
            source.Play();
            ChueCorrect = true;
        }
        else
        {
            Chue.transform.position = ChueInitialPos;
            source.clip = incorrect;
            source.Play();
            DBManager.scoreValue -= 1;
            Song.transform.position = SongInitialPos;
            Ham.transform.position = HamInitialPos;
            Ni.transform.position = NiInitialPos;
            Da.transform.position = DaInitialPos;
            GameControlScript.health -= 1;
        }
    }

    public void DropSong()
    {
        float Distance = Vector3.Distance(Song.transform.position, SongAns.transform.position);
        if (Distance < 50)
        {
            Song.transform.position = SongAns.transform.position;
            DBManager.scoreValue += 2;
            source.clip = Songcorrect[Random.Range(0, Songcorrect.Length)];
            source.Play();
            SongCorrect = true;
        }
        else
        {
            Song.transform.position = SongInitialPos;
            source.clip = incorrect;
            source.Play();
            DBManager.scoreValue -= 1;
            Chue.transform.position = ChueInitialPos;
            Ham.transform.position = HamInitialPos;
            Ni.transform.position = NiInitialPos;
            Da.transform.position = DaInitialPos;
            GameControlScript.health -= 1;
        }
    }

    public void DropHam()
    {
        float Distance = Vector3.Distance(Ham.transform.position, HamAns.transform.position);
        if (Distance < 50)
        {
            Ham.transform.position = HamAns.transform.position;
            DBManager.scoreValue += 2;
            source.clip = Hamcorrect[Random.Range(0, Hamcorrect.Length)];
            source.Play();
            HamCorrect = true;
        }
        else
        {
            Ham.transform.position = HamInitialPos;
            source.clip = incorrect;
            source.Play();
            DBManager.scoreValue -= 1;
            Chue.transform.position = ChueInitialPos;
            Song.transform.position = SongInitialPos;
            Ni.transform.position = NiInitialPos;
            Da.transform.position = DaInitialPos;
            GameControlScript.health -= 1;
        }
    }

    public void DropNi()
    {
        float Distance = Vector3.Distance(Ni.transform.position, NiAns.transform.position);
        if (Distance < 50)
        {
            Ni.transform.position = NiAns.transform.position;
            DBManager.scoreValue += 2;
            source.clip = Nicorrect[Random.Range(0, Nicorrect.Length)];
            source.Play();
            NiCorrect = true;
        }
        else
        {
            Ni.transform.position = NiInitialPos;
            source.clip = incorrect;
            source.Play();
            DBManager.scoreValue -= 1;
            Chue.transform.position = ChueInitialPos;
            Ham.transform.position = HamInitialPos;
            Song.transform.position = SongInitialPos;
            Da.transform.position = DaInitialPos;
            GameControlScript.health -= 1;
        }
    }

    public void DropDa()
    {
        float Distance = Vector3.Distance(Da.transform.position, DaAns.transform.position);
        if (Distance < 50)
        {
            Da.transform.position = DaAns.transform.position;
            DBManager.scoreValue += 2;
            source.clip = Dacorrect[Random.Range(0, Dacorrect.Length)];
            source.Play();
            DaCorrect = true;
        }
        else
        {
            Da.transform.position = DaInitialPos;
            source.clip = incorrect;
            source.Play();
            DBManager.scoreValue -= 1;
            Chue.transform.position = ChueInitialPos;
            Ham.transform.position = HamInitialPos;
            Ni.transform.position = NiInitialPos;
            Song.transform.position = SongInitialPos;
            GameControlScript.health -= 1;
        }
    }
    void Update()
    {
        if (ChueCorrect && SongCorrect && HamCorrect && NiCorrect && DaCorrect)
        {
            Debug.Log("You Win");
           
        }
    }
}
