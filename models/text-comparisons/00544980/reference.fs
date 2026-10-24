FeatureScript 1540;
import(path : "onshape/std/geometry.fs", version : "1540.0");
import(path : "onshape/std/common.fs", version : "1540.0");
const mm = millimeter;
const VERTEX = EntityType.VERTEX;
const EDGE = EntityType.EDGE;
const FACE = EntityType.FACE;
const BODY = EntityType.BODY;
function v(x, y){return vector(x, y);}
function OD(order){return orderDisambiguation(order);}
function OSD(set){return originalSetDisambiguation(set);}
function TD(topology){return topologyDisambiguation(topology);}
function TDD(query){return trueDependencyDisambiguation(query);}
function sQuery(a, b, c) {return sketchEntityQuery(a, b, c);}

annotation { "Feature Type Name" : "Feature", "Feature Type Description" : "" }
export const myFeature = defineFeature(function(context is Context, id is Id, definition is map)
    precondition{}
    {
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F0", { "sketchPlane" : qUnion([Q0])});
            skArc(sketch, "E0", {"start": v(-23.64, 27.3) * mm, "mid": v(-35.81, 31.18) * mm, "end": v(-35.92, 18.4) * mm});
            skArc(sketch, "E1", {"start": v(11.7, 18.4) * mm, "mid": v(11.6, 31.18) * mm, "end": v(-0.58, 27.3) * mm});
            skArc(sketch, "E2", {"start": v(-35.92, 18.4) * mm, "mid": v(-35.81, 5.62) * mm, "end": v(-23.64, 9.51) * mm});
            skArc(sketch, "E3", {"start": v(-0.58, 9.51) * mm, "mid": v(11.6, 5.62) * mm, "end": v(11.7, 18.4) * mm});
            skArc(sketch, "E4", {"start": v(-8.93, 27.3) * mm, "mid": v(-12.1, 30.47) * mm, "end": v(-15.28, 27.3) * mm});
            skLineSegment(sketch, "E5", {"start": v(-23.64, 27.3) * mm, "end": v(-15.28, 27.3) * mm});
            skLineSegment(sketch, "E6.0", {"start": v(-23.64, 9.51) * mm, "end": v(-0.58, 9.51) * mm});
            skPoint(sketch, "E7.orphan", {"position": v(-31.16, 27.3) * mm});
            skPoint(sketch, "E8.orphan", {"position": v(6.94, 27.3) * mm});
            skLineSegment(sketch, "E9.trimOffspring", {"start": v(-8.93, 27.3) * mm, "end": v(-0.58, 27.3) * mm});
            skCircle(sketch, "E10", {"center": v(-12.1, 27.3) * mm, "radius": 1.02 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F0", true);
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "oppositeDirection" : true, "depth" : 2.54 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0"),sQuery(id+"F0.wireOp",EDGE,"E1"),sQuery(id+"F0.wireOp",EDGE,"E2"),sQuery(id+"F0.wireOp",EDGE,"E3"),sQuery(id+"F0.wireOp",EDGE,"E4"),sQuery(id+"F0.wireOp",EDGE,"E5"),sQuery(id+"F0.wireOp",EDGE,"E6.0"),sQuery(id+"F0.wireOp",EDGE,"E9.trimOffspring"),sQuery(id+"F0.wireOp",EDGE,"E10")])],"isStart":true});
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skText(sketch, "E11", { "text": "DUKE", "fontName": "Arimo-Bold.ttf"});
            const initialGuessF2  = {"E11": [-0.0222, 0.01978, 1, 0, 0.00508]};
            skSetInitialGuess(sketch, initialGuessF2);
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F2", true);
            extrude(context, id + "F3", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 1.27 * mm, "offsetDistance" : 25.4 * mm});
        }
        {
            var Q0;
            {var subQ0=sQuery(id+"F0.wireOp",EDGE,"E6.0");var subQ1=sQuery(id+"F0.wireOp",EDGE,"E5");var subQ2=sQuery(id+"F0.wireOp",EDGE,"E0");var subQ3=sQuery(id+"F0.wireOp",EDGE,"E4");var subQ4=sQuery(id+"F0.wireOp",EDGE,"E3");var subQ5=sQuery(id+"F0.wireOp",EDGE,"E1");var subQ6=sQuery(id+"F0.wireOp",EDGE,"E2");var subQ7=sQuery(id+"F0.wireOp",EDGE,"E9.trimOffspring");var subQ8=sQuery(id+"F0.wireOp",EDGE,"E10");Q0=makeQuery(id+"F3.boolean.opBoolean","SPLIT",FACE,{"disambiguationData":[TD([makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([subQ2])]})])],"derivedFrom":makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([subQ2,subQ5,subQ6,subQ4,subQ3,subQ1,subQ0,subQ7,subQ8])],"isStart":true})});}
            var sketch = newSketch(context, id + "F4", { "sketchPlane" : qUnion([Q0])});
            skText(sketch, "E12", { "text": "260-237-1662", "fontName": "Arimo-Bold.ttf"});
            const initialGuessF4  = {"E12": [-0.03433, 0.01155, 1, 0, 0.00508]};
            skSetInitialGuess(sketch, initialGuessF4);
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F4", true);
            extrude(context, id + "F5", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 1.27 * mm, "offsetDistance" : 25.4 * mm});
        }
    });