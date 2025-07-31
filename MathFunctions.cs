        
        //Get a point AROUND the player using Cos and Sin Math functions.
        Vector3 GetPosAroundPlayer()
        {
            float randomAngle = Random.Range(0f, Mathf.PI * 2);
            float radius = Random.Range(2f, 5f);

            float offsetX = Mathf.Cos(randomAngle) * radius;
            float offsetZ = Mathf.Sin(randomAngle) * radius;

            Vector3 randomPos = new Vector3(player.transform.position.x + offsetX, transform.position.y, player.transform.position.z + offsetZ);

            return randomPos;
        }