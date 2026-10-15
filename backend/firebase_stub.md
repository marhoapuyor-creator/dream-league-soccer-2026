# Firebase integration (stub)

Use Firebase for authentication and real-time database or Firestore for leaderboards.

Steps (high-level):
1. Create a Firebase project at https://console.firebase.google.com
2. For web: add Firebase config to your index.html and include Firebase SDK.
3. Example to sign in anonymously:

```js
firebase.auth().signInAnonymously().then((user) => {
  console.log('Signed in', user);
});
```

4. Example to store leaderboard entry (Firestore):

```js
const db = firebase.firestore();
await db.collection('leaderboard').add({ name: 'Player', score: 123, timestamp: firebase.firestore.FieldValue.serverTimestamp() });
```

