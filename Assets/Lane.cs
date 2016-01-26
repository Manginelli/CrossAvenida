using UnityEngine;
using System.Collections;

public class Lane : MonoBehaviour {

    // Obstaculos que matam o personagem principal
    GameObject[] obstacles = new GameObject[12];

    // O padrão dos blocos da lane e o contador
    // Quando true, cria um bloco, quando false, deixa em aberto
    bool[] pattern = new bool[12];

    // Z do objeto e dos obstaculos
    float zeta;

    // Faz o Z ser a da lane e cria a lane, se ela não for a A
    // pois a A é a lane que se encontra na localidade do jogador
    // no inicio fo jogo
    void Start()
    {
        zeta = gameObject.transform.position.z;
        if (gameObject.name != "Lane A")
        {
            CreateLane();
        }
    }

    // Cria a lane baseada no padrão fornecido
    void CreateLane()
    {
        pattern = LanePatterns.Pattern();
        for (int i = 0; i < 12; i++)
        {
            if (pattern[i])
            {
                obstacles[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);
                obstacles[i].transform.position = new Vector3((i * 2) - 12,
                                                              0,
                                                              zeta);
            }
        }
    }

    // limpa a lane para poder criar outra no lugar
    void CleanLane()
    {
        for (int i = 0; i < 12; i++)
        {
            Destroy(obstacles[i]);
            obstacles[i] = null;
        }
    }

    // Função que atualiza a posição dos objetos na horizontal
    // É chamada de x em x tempos, definido no LaneControls
	public void UpdateHorizontal()
    {
        for(int i = 11; i > -1; i--)
        {
            if (obstacles[i] != null)
            {
                if (obstacles[i].transform.position.x - 2 != -14)
                {
                    obstacles[i].transform.position = new Vector3(obstacles[i].transform.position.x - 2,
                                                              0,
                                                              zeta);
                }
                else
                {
                    Destroy(obstacles[i]);
                    obstacles[i] = null;
                    if (pattern[i])
                    {
                        obstacles[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        obstacles[i].transform.position = new Vector3(12,
                                                                      0,
                                                                      zeta);
                    }
                }
                
            }
        } 
    }

    // FunçÃo que atualiza a posição dos objetos na vertical
    // É chamada toda vez que o jogador aperta a tecla W
    public void UpdateVertical()
    {
        if (gameObject.transform.position.z - 2f == 0f)
        {
            zeta = 14f;
            CleanLane();
            CreateLane();
        }
        else
        {
            zeta = gameObject.transform.position.z - 2f;
        }

        gameObject.transform.position = new Vector3(gameObject.transform.position.x,
                                                    0,
                                                    zeta);
        for (int i = 11; i > -1; i--)
        {
            if (obstacles[i] != null)
            {
                obstacles[i].transform.position = new Vector3(obstacles[i].transform.position.x,
                                                              0,
                                                              zeta);
            }
        }
    }

}
