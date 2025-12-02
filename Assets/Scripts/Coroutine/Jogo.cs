using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace CourotineLesson
{
    public class Jogo : MonoBehaviour
    {
        [SerializeField] int numMovimento;
        [SerializeField] NPC npc1;
        [SerializeField] NPC npc2;
        [SerializeField] int delayCoroutine;
        [SerializeField] List<Plataforma> plataformas;
        [SerializeField] TextMeshProUGUI turnos;
        [SerializeField] GameObject telaVitoria;

        void Start()
        {
            turnos.text = "Turno: 0";
            StartCoroutine(Partida());
        }

        void Update()
        {
        
        }

        IEnumerator Partida()
        {
            while (plataformas.Count > 0)
            {
                yield return new WaitForSeconds(delayCoroutine);
                yield return Turno();
                AtualizarListaPlataformas();
            }

            telaVitoria.SetActive(true);
            TextMeshProUGUI textVitoria = telaVitoria.GetComponentInChildren<TextMeshProUGUI>();

            if(npc1.Pontos > npc2.Pontos)
            {
                textVitoria.text = "NPC 1 ganhou!!";
            }
            else if(npc2.Pontos > npc1.Pontos)
            {
                textVitoria.text = "NPC 2 ganhou!!";
            }
            else if(npc1.Pontos == npc2.Pontos)
            {
                textVitoria.text = "Empate!";
            }
        }

        IEnumerator Turno()
        {
            AtualizarListaPlataformas();

            yield return Movimento(npc1);
            yield return Movimento(npc2);

        }

        IEnumerator Movimento(NPC npc)
        {
            int movimentoRestante = numMovimento;
            UpdateTurno(npc, movimentoRestante);
            while (movimentoRestante > 0)
            {                
                int plataformaAtual = Random.Range(0, plataformas.Count);

                if(plataformas.Count <= 0)
                {
                    break;
                }

                if (plataformas[plataformaAtual].Usos > 0)
                {
                    yield return new WaitForSeconds(delayCoroutine);
                    npc.Mover(plataformas[plataformaAtual]);
                    movimentoRestante -= 1;
                    UpdateTurno(npc, movimentoRestante);
                }
                else
                {
                    AtualizarListaPlataformas();
                }
            }
            yield return new WaitForSeconds(delayCoroutine);
            npc.transform.position = npc.PosInicial;
        }

        void AtualizarListaPlataformas()
        {
            for(int i = 0; i < plataformas.Count; i++)
            {
                if (plataformas[i].Usos <= 0)
                {
                    plataformas.Remove(plataformas[i]);
                }
            }
        }

        void UpdateTurno(NPC npc, int acoes)
        {
            turnos.text = $"{npc.name} está jogando, ações restantes: {acoes}";
        }
    }
}
