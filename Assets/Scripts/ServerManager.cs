using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.Netcode.Components;

public class ServerManager : NetworkBehaviour
{
    // public static ServerManager Instance;
    // public NetworkVariable<ulong> activePlayer = new NetworkVariable<ulong>(writePerm: NetworkVariableWritePermission.Server);
    // public NetworkVariable<int> p0Score = new NetworkVariable<int>(writePerm: NetworkVariableWritePermission.Server);
    // public NetworkVariable<int> p1Score = new NetworkVariable<int>(writePerm: NetworkVariableWritePermission.Server);

    // public NetworkVariable<float> timer = new NetworkVariable<float>(writePerm: NetworkVariableWritePermission.Server);
    // public NetworkVariable<float> spawnTimer = new NetworkVariable<float>(writePerm: NetworkVariableWritePermission.Server);

    // public NetworkVariable<bool> inGame = new NetworkVariable<bool>(writePerm: NetworkVariableWritePermission.Server);

    // // public List<Car> players = new List<Car>();
    // // public List<PPassenger> balls = new List<PPassenger>();
    // public Material p0mat, p1mat, skillmat;
    // public GameObject resetButton;
    // public TMP_Text tMP_Text;
    // public GameObject passenger;
    // private void Awake()
    // {
    //     if (Instance == null) Instance = this;
    //     else Destroy(gameObject);
    // }
    // public override void OnNetworkSpawn()
    // {
    //     if (!IsServer) return;
    //     base.OnNetworkSpawn();
    // }
    // [Rpc(SendTo.Server)]
    // public void ChangeActivePlayerRpc()
    // {
    //     activePlayer.Value = (ulong)(activePlayer.Value == 1 ? 0 : 1);
    // }
    // // public void AddToPlayers(Car player)
    // // {
    // //     players.Add(player);
    // //     if (players.Count > 1)
    // //     {
    // //         inGame.Value = true;
    // //         PlayersStandByRpc();
    // //     }
    // // }

    // [Rpc(SendTo.ClientsAndHost)]
    // public void PlayersStandByRpc()
    // {
    //     inGame.Value = true;
    // }
    // [Rpc(SendTo.Server)]
    // public void PlayersReadyRpc()
    // {

    // }
    // [Rpc(SendTo.ClientsAndHost)]
    // public void PlayersAllSetRpc()
    // {

    // }


    // [Rpc(SendTo.Server)]
    // public void PlayersPickRpc()
    // {

    // }
    // [Rpc(SendTo.ClientsAndHost)]
    // public void PlayersAllDoneRpc(int winner, int p0Score, int p1Score)
    // {

    // }
    // // public void AddToBalls(PPassenger ball)
    // // {
    // //     balls.Add(ball);
    // // }
    // [Rpc(SendTo.ClientsAndHost)]
    // public void DeleteAllBallsRpc()
    // {
    //     // foreach (PPassenger ball in balls)
    //     // {
    //     //     ball.DespawnSelfEveryoneRpc();
    //     // }
    //     // balls.Clear();
    // }
    // [Rpc(SendTo.Server)]
    // public void PlayerScoreRpc(ulong playerID)
    // {
    //     // if (playerID == players[0].GetComponent<Car>().myOwnerID)
    //     // {
    //     //     p0Score.Value++;
    //     // }
    //     // else
    //     // {
    //     //     p1Score.Value++;
    //     // }
    // }
    // [Rpc(SendTo.ClientsAndHost)]
    // public void PlayersResetRpc()
    // {
    //     resetButton.SetActive(true);
    // }
    // [Rpc(SendTo.Everyone)]
    // public void RestGameRpc()
    // {
    //     resetButton.SetActive(false);
    //     // players[0].GetComponent<NetworkRigidbody>().SetPosition(new Vector3(-3, 0));
    //     // players[1].GetComponent<NetworkRigidbody>().SetPosition(new Vector3(3, 0));
    //     // players[0].GetComponent<NetworkRigidbody>().SetRotation(Quaternion.identity);
    //     // players[1].GetComponent<NetworkRigidbody>().SetRotation(Quaternion.identity);
    //     if (IsServer)
    //     {
    //         // players[0].GetComponent<Car>().pPassengers.Clear();
    //         // players[1].GetComponent<Car>().pPassengers.Clear();

    //         activePlayer.Value = 0;
    //         inGame.Value = true;
    //         timer.Value = Time.time + 90;
    //         spawnTimer.Value = 0;
    //         DeleteAllBallsRpc();
    //         p0Score.Value = 0;
    //         p1Score.Value = 0;
    //     }
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     tMP_Text.text = "P0 Score: " + p0Score.Value + ", P1 Score: " + p1Score.Value;
    //     if (!IsServer) return;
    //     if (inGame.Value)
    //     {
    //         if (timer.Value - Time.time < 0)
    //         {
    //             inGame.Value = false;
    //             PlayersResetRpc();
    //         }
    //         else
    //         {
    //             if (spawnTimer.Value < Time.time)
    //             {
    //                 SpawnPassengerRpc(Random.Range(0, 6), new Vector3(Random.Range(-90, 90), Random.Range(-80, 80)));
    //                 spawnTimer.Value = Time.time + 2;
    //             }
    //         }
    //     }
    // }
    // [Rpc(SendTo.ClientsAndHost)]
    // public void SpawnPassengerRpc(int val, Vector3 pos)
    // {
    //     NetworkObject instance = Instantiate(passenger).GetComponent<NetworkObject>();
    //     instance.transform.position = pos;
    //     instance.Spawn();
    //     instance.transform.GetChild(val).gameObject.SetActive(true);
    // }
    // public enum Phase
    // {
    //     None, P1, P2, P1Won, P2Won
    // }
}
